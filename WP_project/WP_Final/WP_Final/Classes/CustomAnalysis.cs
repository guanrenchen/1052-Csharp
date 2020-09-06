using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_Final.Classes
{
    class CustomAnalysis
    {

        public static List<double> Filter_ItemArrayToListDouble(object[] itemArray)
        {
            List<object> itemList = itemArray.ToList();
            itemList.RemoveAt(0);
            return itemList.Select(x => x==DBNull.Value? double.NaN: double.Parse(x.ToString()))
                           .ToList();
        }

        public static List<double> Filter_ListDoubleValid(List<double> list)
        {
            return list.Contains(double.NaN) ?
                   list.Where(x => !double.IsNaN(x)).ToList() :
                   list;
        }

        public static double CalculateMean(List<double> list)
        {
            double sum = 0.0f;
            list.ForEach(x => sum+=x);
            return sum/list.Count;
        }

        public static double CalculateMedian(List<double> list)
        {
            list.Sort();
            int n = list.Count;
            return n == 0 ? double.NaN : list.ElementAt(n % 2 == 1 ? n / 2 : n / 2 + 1);
        }

        public static double CalculateVariance(List<double> list)
        {
            double mean = CalculateMean(list);
            double sum = 0.0f;
            list.ForEach(x => sum += Math.Pow(x - mean, 2.0f));
            return sum/(list.Count-1);
        }

        public static double CalculateStandardDeviation(List<double> list)
        {
            return Math.Sqrt(CalculateVariance(list)); ;
        }

        public static double CalculateCovariance(List<double> list1, List<double> list2, out int dataCount)
        {
            if (list1.Count != list2.Count)
            {
                dataCount = 0;
                return double.NaN;
            }

            for(int i=0; i<list1.Count; ++i)
            {
                if(double.IsNaN(list1[i]) || double.IsNaN(list2[i]))
                {
                    list1.RemoveAt(i);
                    list2.RemoveAt(i);
                    --i;
                }
            }

            double mean1 = CalculateMean(list1), mean2 = CalculateMean(list2);
            double covariance = 0.0f;
            for(int i=0; i<list1.Count; ++i)
                covariance += (list1[i] - mean1) * (list2[i] - mean2);
            covariance /= list1.Count-1;

            dataCount = list1.Count;
            return covariance;
        }

        public static double CalculateCorrelation(List<double> list1, List<double> list2, out int n)
        {
            double Sxy = CalculateCovariance(list1, list2, out n),
                   Sx = CalculateStandardDeviation(list1),
                   Sy = CalculateStandardDeviation(list2);

            return Sxy / Sx / Sy;
        }
    }
}
