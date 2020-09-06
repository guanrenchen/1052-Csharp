using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_Final.Classes;

using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers

namespace WP_Final.Forms
{
    public partial class ChartDialog : Form
    {
        public ChartDialog(DataTable table, string title, string colName, string sortOrder)
        {
            InitializeComponent();
            if (table == null || title.Equals("") || colName.Equals("")) Close();

            //test 
            DataView dv = table.DefaultView;
            dv.Sort = colName + " " + sortOrder;
            table = dv.ToTable();

            // set chart
            cartesianChart1.DisableAnimations = true;
            cartesianChart1.DataTooltip = null;
            cartesianChart1.Hoverable = false;
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            cartesianChart1.Zoom = ZoomingOptions.Y;
            cartesianChart1.Background = System.Windows.Media.Brushes.White;
            cartesianChart1.LegendLocation = LegendLocation.Top;
            cartesianChart1.AxisX.Add(new Axis());
            List<string> yLabel = new List<string>();
            foreach (DataRow row in table.Rows) yLabel.Add(row[0].ToString());
            cartesianChart1.AxisY.Add(new Axis
            {
                Labels = yLabel,
                Separator = new Separator{ Step = 1 }
            });

            // set xlabel;

            // set value
            List<double> doubleList = new List<double>();
            foreach (DataRow row in table.Rows) doubleList.Add((double)row[colName]);
            doubleList = doubleList.Select(x => double.IsNaN(x) ? 0.0f : x).ToList();
            
            // add value
            cartesianChart1.Series.Add(new RowSeries
            {
                DataLabels = true,
                Title = title + "---" + colName,
                Values = new ChartValues<double>(doubleList),
                StrokeThickness = 0.5f
            });
        }

        private void cartesianChart1_DataClick(object sender, ChartPoint chartPoint)
        {
            cartesianChart1.AxisX[0].MaxValue = double.NaN;
            cartesianChart1.AxisX[0].MinValue = double.NaN;
            cartesianChart1.AxisY[0].MaxValue = double.NaN;
            cartesianChart1.AxisY[0].MinValue = double.NaN;
        }
    }
}
