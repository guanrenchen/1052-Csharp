using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
//using LiveCharts.WinForms; //the WinForm wrappers

namespace WP_Final.Classes
{
    class CustomChart
    {
        public static readonly string[] CHART_TYPES = new string[]{ "Line", "Column", "Stacked Area", "Stacked Column"};

        public static LiveCharts.Definitions.Series.ISeriesView GenerateSeries(object[] arr, string chartType)
        {
            return GenerateSeries(arr.ToList(), chartType);
        }

        public static LiveCharts.Definitions.Series.ISeriesView GenerateSeries(List<object> list, string chartType)
        {
            List<double> doubleList = list.Where(x => !x.GetType().IsEquivalentTo(typeof(string)))
                                          .Select(x => x == DBNull.Value ? double.NaN : double.Parse(x.ToString()))
                                          .ToList();
            switch (chartType)
            {
                case "Line":
                    return new LineSeries
                    {
                        Title = list.ElementAt(0).ToString(),
                        Values = new ChartValues<double>(doubleList),
                        LineSmoothness = 0.0f,
                        PointGeometry = DefaultGeometries.None,
                        Fill = System.Windows.Media.Brushes.Transparent
                    };
                case "Column":
                    doubleList = doubleList.Select(x => double.IsNaN(x) ? 0.0f : x).ToList();
                    return new ColumnSeries
                    {
                        Title = list.ElementAt(0).ToString(),
                        Values = new ChartValues<double>(doubleList)
                    };
                case "Stacked Area":
                    doubleList = doubleList.Select(x => double.IsNaN(x) ? 0.0f : x).ToList();
                    return new StackedAreaSeries
                    {
                        Title = list.ElementAt(0).ToString(),
                        Values = new ChartValues<double>(doubleList),
                        LineSmoothness = 0.0f,
                        PointGeometry = DefaultGeometries.None
                    };
                case "Stacked Column":
                    doubleList = doubleList.Select(x => double.IsNaN(x) ? 0.0f : x).ToList();
                    return new StackedColumnSeries
                    {
                        Title = list.ElementAt(0).ToString(),
                        Values = new ChartValues<double>(doubleList)
                    };
                case "Row":
                    doubleList = doubleList.Select(x => double.IsNaN(x) ? 0.0f : x).ToList();
                    return new RowSeries
                    {
                        Title = list.ElementAt(0).ToString(),
                        Values = new ChartValues<double>(doubleList)
                    };
                default:
                    return new LineSeries
                    {
                        Title = list.ElementAt(0).ToString(),
                        Values = new ChartValues<double>(doubleList),
                        LineSmoothness = 1.0f,
                        PointGeometry = DefaultGeometries.None,
                        Fill = System.Windows.Media.Brushes.Transparent
                    };
            }
        }
    }
}
