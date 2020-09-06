using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WP_Final.Classes;

using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers

namespace WP_Final.Forms
{
    public partial class MainWindow2 : Form
    {
        private DataTable table1, table2;

        public MainWindow2()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // subscribe
            exitToolStripMenuItem.Click += CustomForm.Exit_Click;
            
            InitializeRelation();
            registerToolStripMenuItem.Enabled = Login.administrator;
            addTableToolStripMenuItem.Enabled = Login.administrator;
            deleteTableToolStripMenuItem.Enabled = Login.administrator;
        }
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.administrator)
                CustomForm.ShowDialogPause(this, new UserManage());
            else
                CustomForm.ShowDialogPause(this, "Access Denied");
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomForm.SwitchToForm(this, new Login());
        }
        private void addTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomForm.ShowDialogPause(this, new CreateTable());
        }
        private void deleteTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomForm.ShowDialogPause(this, new DeleteTable());
        }
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomForm.SwitchToForm(this, new MainWindow());
        }
        private List<string> AcquireFilter()
        {
            List<string> filter = new List<string>();
            foreach (ToolStripMenuItem tsmi in filterToolStripMenuItem.DropDownItems)
                if (tsmi.Checked && Custom.filterList.ContainsKey(tsmi.Text))
                    filter.AddRange(Custom.filterList[tsmi.Text]);
            return filter;
        }
        // MUTUAL END

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || table1==null || table2==null) return;
            GenerateChart();
        }

        // NORMAL START
        private void InitializeRelation()
        {
            // initialize filter
            filterToolStripMenuItem.DropDownItems.Clear();
            Custom.BuildFilterList();
            Custom.filterList.Keys.ToList().ForEach(x => {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(x.ToString());
                tsmi.CheckOnClick = true;
                tsmi.Click += UpdateListBox;
                filterToolStripMenuItem.DropDownItems.Add(tsmi);
            });

            // initialize chart
            cartesianChart1.DisableAnimations = true;
            cartesianChart1.DataTooltip = null;
            cartesianChart1.Hoverable = false;
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            cartesianChart1.Zoom = ZoomingOptions.X;
            cartesianChart1.Background = System.Windows.Media.Brushes.White;
            cartesianChart1.LegendLocation = LegendLocation.Top;
            cartesianChart1.AxisX.Add(new Axis {
                Separator = new Separator {
                    Stroke = System.Windows.Media.Brushes.Black,
                    StrokeThickness = 0.5f,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 10 })
                }
            });
            cartesianChart1.AxisY.Add(new Axis {
                LabelFormatter = x => x.ToString("N"),
                Position = AxisPosition.LeftBottom,
                Foreground = System.Windows.Media.Brushes.DodgerBlue
            });
            cartesianChart1.AxisY.Add(new Axis {
                LabelFormatter = x => x.ToString("N"),
                Position = AxisPosition.RightTop,
                Foreground = System.Windows.Media.Brushes.IndianRed
            });

            // initialize listBoxes
            listBox1.Items.Clear();

            // initialize comboBoxes
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            // initialize sourceTable
            table1 = new DataTable();
            table2 = new DataTable();

            // initialize datagridview1
            DataTable analysis = new DataTable();
            analysis.Columns.Add(new DataColumn("ID", typeof(string)));
            analysis.Columns.Add(new DataColumn("Correlation", typeof(double)));
            analysis.Columns.Add(new DataColumn("Data Count", typeof(int)));
            dataGridView1.DataSource = analysis;
        }
        private void UpdateComboBox(object sender, EventArgs e)
        {
            try
            {
                ComboBox comboBox = (ComboBox)sender;
                comboBox.Items.Clear();
                Custom.connOpenData.Open();
                foreach (DataRow row in Custom.connOpenData.GetSchema("Tables").Rows)
                    comboBox.Items.Add((string)row[2]);
            }
            catch (Exception ex)
            {
                CustomForm.ShowDialogException(this, ex);
            }
            finally
            {
                if (Custom.connOpenData.State == ConnectionState.Open) Custom.connOpenData.Close();
            }
        }
        private void UpdateTable(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("") || comboBox2.Text.Equals("")) return;
            try
            {
                Custom.connOpenData.Open();

                table1 = new DataTable();
                if (!string.IsNullOrEmpty(comboBox1.Text))
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + comboBox1.Text, Custom.connOpenData))
                        adapter.Fill(table1);
                table2 = new DataTable();
                if (!string.IsNullOrEmpty(comboBox2.Text))
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + comboBox2.Text, Custom.connOpenData))
                        adapter.Fill(table2);

                UpdateListBox(sender, e);
            }
            catch (Exception ex)
            {
                CustomForm.ShowDialogException(this, ex);
            }
            finally
            {
                if (Custom.connOpenData.State == ConnectionState.Open) Custom.connOpenData.Close();
            }
        }
        private void UpdateListBox(object sender, EventArgs e)
        {
            try
            {
                List<string> filter = AcquireFilter();

                listBox1.Items.Clear();

                List<string> table2RowID = new List<string>();
                foreach (DataRow row in table2.Rows)
                    table2RowID.Add(row[0].ToString());

                foreach (DataRow row in table1.Rows)
                {
                    string rowID = row[0].ToString();
                    if (!table2RowID.Contains(rowID)) continue;
                    listBox1.Items.Add(rowID);
                }

                if(filter.Count!=0)
                    for(int i=0; i<listBox1.Items.Count; ++i)
                        if (!filter.Contains(listBox1.Items[i]))
                            listBox1.Items.RemoveAt(i--);

                GenerateAnalysis();
            }
            catch (Exception ex)
            {
                CustomForm.ShowDialogException(this, ex);
            }
            finally
            {
                if (Custom.connOpenData.State == ConnectionState.Open) Custom.connOpenData.Close();
            }
        }

        // BELOW ALL UNDER CONSTRUCTION

        private void GenerateChart()
        {
            cartesianChart1_DataClick(null, null);

            groupBox_Chart.Text = listBox1.SelectedItem.ToString();

            // clear series
            cartesianChart1.Series.Clear();

            // set axis
            List<string> xLabel = new List<string>() ;
            foreach (DataColumn col in table1.Columns)
            {
                if (!col.DataType.IsEquivalentTo(typeof(double))) continue;
                xLabel.Add(col.ColumnName);
            }
            cartesianChart1.AxisX[0].Labels = xLabel;

            // draw chart
            SeriesCollection seriesCollection = new SeriesCollection();
            object[] tempItemArray = ItemArrayWithRowID(table1, listBox1.SelectedItem.ToString());
            seriesCollection.Add(
                new LineSeries {
                    Title = comboBox1.Text,
                    Values = new ChartValues<double>(CustomAnalysis.Filter_ItemArrayToListDouble(tempItemArray)),
                    LineSmoothness = 0.0f,
                    PointGeometry = DefaultGeometries.None,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    ScalesYAt = 0
                }
            );
            tempItemArray = ItemArrayWithRowID(table2, listBox1.SelectedItem.ToString());
            seriesCollection.Add(
                new LineSeries {
                    Title = comboBox2.Text,
                    Values = new ChartValues<double>(CustomAnalysis.Filter_ItemArrayToListDouble(tempItemArray)),
                    LineSmoothness = 0.0f,
                    PointGeometry = DefaultGeometries.None,
                    Fill = System.Windows.Media.Brushes.Transparent,
                    ScalesYAt = 1
                }
            );
            cartesianChart1.Series = seriesCollection;
        }
        private void GenerateAnalysis()
        {
            DataTable analysis = (DataTable)dataGridView1.DataSource;
            analysis.Clear();

            for(int i=0; i<listBox1.Items.Count; ++i)
            {
                string rowID = listBox1.Items[i].ToString();
                List<double> listDouble1 = CustomAnalysis.Filter_ItemArrayToListDouble(ItemArrayWithRowID(table1, rowID));
                List<double> listDouble2 = CustomAnalysis.Filter_ItemArrayToListDouble(ItemArrayWithRowID(table2, rowID));
                DataRow newRow = analysis.NewRow();
                int dataCount = 0;
                newRow.ItemArray = new object[] {
                    rowID,
                    CustomAnalysis.CalculateCorrelation(listDouble1, listDouble2, out dataCount),
                    dataCount
                };
                analysis.Rows.Add(newRow);
            }
        }

        private void button_SortOrder_Click(object sender, EventArgs e)
        {
            button_SortOrder.Text = button_SortOrder.Text.Equals("asc") ? "desc" : "asc";
        }

        private void button_ShowChartDialog_Click(object sender, EventArgs e)
        {
            if (dataGridView1 == null) return;
            DataTable dt = (DataTable)dataGridView1.DataSource;
            string title = comboBox1.Text + "---" + comboBox2.Text;
            this.Enabled = false;
            new ChartDialog(dt, title, dt.Columns[1].ColumnName, button_SortOrder.Text)
                .ShowDialog();
            this.Enabled = true;
        }

        private void cartesianChart1_DataClick(object sender, ChartPoint chartPoint)
        {
            cartesianChart1.AxisX[0].MaxValue = double.NaN;
            cartesianChart1.AxisX[0].MinValue = double.NaN;
            cartesianChart1.AxisY[0].MaxValue = double.NaN;
            cartesianChart1.AxisY[0].MinValue = double.NaN;
        }

        private object[] ItemArrayWithRowID(DataTable table, string rowID)
        {
            foreach (DataRow row in table.Rows)
                if (row[0].ToString().Equals(rowID))
                    return row.ItemArray;
            return null;
        }
        // NORMAL END
    }
}
