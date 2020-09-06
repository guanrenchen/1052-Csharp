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
    public partial class MainWindow : Form
    {
        private DataTable sourceTable;

        // MUTUAL START
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // subscribe
            checkedListBox_Row.Click += CustomForm.checkedListBox_Click;
            exitToolStripMenuItem.Click += CustomForm.Exit_Click;

            InitializeNormal();
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
            CustomForm.ShowDialogPause(this, new UserManage());
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
        private void relationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomForm.SwitchToForm(this, new MainWindow2());
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

        // NORMAL START
        private void InitializeNormal()
        {
            // initialize filter
            filterToolStripMenuItem.DropDownItems.Clear();
            Custom.BuildFilterList();
            Custom.filterList.Keys.ToList().ForEach(x => {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(x.ToString());
                tsmi.CheckOnClick = true;
                tsmi.Click += UpdateCheckedListBoxRow;
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
            cartesianChart1.AxisX.Add(new Axis
            {
                Separator = new Separator
                {
                    Stroke = System.Windows.Media.Brushes.Black,
                    StrokeThickness = 0.5f,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 10 })
                }
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Value",
                LabelFormatter = x => x.ToString("N"),
                Separator = new Separator
                {
                    Stroke = System.Windows.Media.Brushes.Black,
                    StrokeThickness = 0.5f,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 10 })
                }
            });

            // initialize checkedListBox_Row
            checkedListBox_Row.Items.Clear();

            // initialize comboBoxes
            comboBox_Table.Items.Clear();
            comboBox_Chart.Items.Clear();
            comboBox_Chart.Items.AddRange(CustomChart.CHART_TYPES);
            comboBox_Column.Items.Clear();
            comboBox_Column.Items.Add("Mean");
            comboBox_Column.Items.Add("Median");
            comboBox_Column.Items.Add("Standard Deviation");
            
            // initialize sourceTable
            sourceTable = new DataTable();

            // initialize datagridview1
            DataTable analysis = new DataTable();
            analysis.Columns.Add(new DataColumn("ID", typeof(string)));
            analysis.Columns.Add(new DataColumn("Mean", typeof(double)));
            analysis.Columns.Add(new DataColumn("Median", typeof(double)));
            analysis.Columns.Add(new DataColumn("Standard Deviation", typeof(double)));
            analysis.Columns.Add(new DataColumn("Data Count", typeof(int)));
            dataGridView1.DataSource = analysis;
        }
        private void UpdateTable(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBox_Table.Text)) return;
                sourceTable = new DataTable();
                Custom.connOpenData.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + comboBox_Table.Text, Custom.connOpenData))
                    adapter.Fill(sourceTable);
                UpdateCheckedListBoxRow(sender, e);
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
        private void UpdateCheckedListBoxRow(object sender, EventArgs e)
        {
            try
            {
                List<string> filter = AcquireFilter();
                CustomForm.InitializeCheckedListBox(checkedListBox_Row, false);
                // add row name to checkedlistbox
                foreach (DataRow row in sourceTable.Rows)
                    if (filter.Count == 0 || filter.Contains(row[0].ToString()))
                        checkedListBox_Row.Items.Add(row[0].ToString(), false);
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
        private void UpdateComboBoxTable(object sender, EventArgs e)
        {
            try
            {
                comboBox_Table.Items.Clear();
                Custom.connOpenData.Open();
                foreach (DataRow row in Custom.connOpenData.GetSchema("Tables").Rows)
                    comboBox_Table.Items.Add((string)row[2]);
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
        private void GenerateChart()
        {
            cartesianChart1_DataClick(null, null);

            // clear series
            cartesianChart1.Series.Clear();

            // set axis
            List<string> xLabel = new List<string>();
            foreach (DataColumn col in sourceTable.Columns)
            {
                if (col.DataType.IsEquivalentTo(typeof(string))) continue;
                xLabel.Add(col.ColumnName);
            }
            cartesianChart1.AxisX[0].Labels = xLabel;

            // draw chart of checked rows
            SeriesCollection seriesCollection = new SeriesCollection();
            foreach (DataRow row in sourceTable.Rows)
            {
                // skip unchecked rows
                if (!checkedListBox_Row.CheckedItems.Contains(row[0].ToString())) continue;
                seriesCollection.Add(CustomChart.GenerateSeries(row.ItemArray, comboBox_Chart.Text));
            }
            cartesianChart1.Series = seriesCollection;
        }
        private void GenerateAnalysis()
        {
            DataTable analysis = (DataTable)dataGridView1.DataSource;
            analysis.Clear();

            List<double> listDouble = new List<double>();
            DataRow newRow = null;
            foreach(DataRow row in sourceTable.Rows)
            {
                if (!checkedListBox_Row.CheckedItems.Contains(row[0].ToString())) continue;
                newRow = analysis.NewRow();

                listDouble.Clear();
                listDouble = CustomAnalysis.Filter_ItemArrayToListDouble(row.ItemArray);
                listDouble = CustomAnalysis.Filter_ListDoubleValid(listDouble);

                newRow.ItemArray = new object[]{
                    row[0].ToString(),
                    CustomAnalysis.CalculateMean(listDouble),
                    CustomAnalysis.CalculateMedian(listDouble),
                    CustomAnalysis.CalculateStandardDeviation(listDouble),
                    listDouble.Count                   
                };
                analysis.Rows.Add(newRow);
            }
        }
        private void button_Analyze_Click(object sender, EventArgs e)
        {
            if (sourceTable == null || dataGridView1 == null) return;
            GenerateAnalysis();
        }
        private void button_Draw_Click(object sender, EventArgs e)
        {
            // check if a sourceTable is selected
            if (comboBox_Table.Text.Equals("") || sourceTable==null) return;
            if (checkedListBox_Row.CheckedItems.Count > 25)
            {
                CustomForm.ShowDialogPause(this, "TOO MANY ROWS");
                return;
            }
            GenerateChart();
        }

        private void button_ShowChartDialog_Click(object sender, EventArgs e)
        {
            if (dataGridView1 == null || comboBox_Table.Text.Equals("") || comboBox_Column.Text.Equals("")) return;

            this.Enabled = false;
            new ChartDialog((DataTable)dataGridView1.DataSource, comboBox_Table.Text, comboBox_Column.Text, button_SortOrder.Text)
                .ShowDialog();
            this.Enabled = true;
        }

        private void button_SortOrder_Click(object sender, EventArgs e)
        {
            button_SortOrder.Text = button_SortOrder.Text.Equals("asc") ? "desc" : "asc";
        }

        private void cartesianChart1_DataClick(object sender, ChartPoint chartPoint)
        {
            cartesianChart1.AxisX[0].MaxValue = double.NaN;
            cartesianChart1.AxisX[0].MinValue = double.NaN;
            cartesianChart1.AxisY[0].MaxValue = double.NaN;
            cartesianChart1.AxisY[0].MinValue = double.NaN;
        }
        // NORMAL END
    }
}
