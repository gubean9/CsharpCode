using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz07
{
    internal class Program
    {
        /* 원본 코드
        static void Main(string[] args)
        {
            double mean = 0;

            Mean(ref 1, 2, 3, 4, 5, mean);
            Console.WriteLine($"평균 : {mean}");
        }

        public static void Mean(ref double a, ref double b, ref double c, ref double d, ref double e, double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
        */

        // 수정한 코드
        static void Main(string[] args)
        {
            double mean = 0;
            double a = 1, b = 2, c = 3, d = 4, e = 5;

            Mean(a, b, c, d, e, ref mean);
            Console.WriteLine($"평균 : {mean}");
        }

        public static void Mean(double a, double b, double c, double d, double e, ref double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
