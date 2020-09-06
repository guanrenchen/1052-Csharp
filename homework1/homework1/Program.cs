using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        public class student
        {
            public String name;
            public int seatNum, chinese, english, math; 

            public override string ToString()
            {
                return seatNum.ToString()   + "\t" +
                       chinese.ToString()   + "\t" +
                       english.ToString()   + "\t" +
                       math.ToString()      + "\t" +
                       name;
            }
        }

        static void Main(string[] args)
        {
            student[] list = { };
            while (true)
            {
                try
                {
                    Console.WriteLine("1)輸入 2)印出 3)排序(以國文成績排序) -1)離開");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Array.Resize(ref list, list.Length + 1);
                            list[list.GetUpperBound(0)] = new student();
                            Console.WriteLine("請輸入座號:"); list.Last().seatNum = int.Parse(Console.ReadLine());
                            Console.WriteLine("請輸入姓名:"); list.Last().name = Console.ReadLine();
                            Console.WriteLine("請輸入國文成績:"); list.Last().chinese = int.Parse(Console.ReadLine());
                            Console.WriteLine("請輸入英文成績:"); list.Last().english = int.Parse(Console.ReadLine());
                            Console.WriteLine("請輸入數學成績:"); list.Last().math = int.Parse(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("座號\t國文\t英文\t數學\t姓名");
                            Console.WriteLine("====================================");
                            for (int i = 0; i < list.Length; ++i) Console.WriteLine(list[i].ToString());
                            break;
                        case 3:
                            Array.Sort(list, (a, b) => a.chinese.CompareTo(b.chinese));
                            break;
                        case -1:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e) { Console.Clear(); }
            }
        }
    }
}
