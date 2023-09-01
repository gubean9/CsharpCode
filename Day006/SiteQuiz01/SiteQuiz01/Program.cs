using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    class Totalscore
    {
        public int Total(int kor, int eng, int math)
        {
            return kor + eng + math;
        }
        public double Avg(double kor, double eng, int math)
        {
            return (kor + eng + math) / 3.0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Totalscore total = new Totalscore();

            Console.Write("국어 : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("영어 : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("수학 : ");
            int c = int.Parse(Console.ReadLine());


            Console.WriteLine($"총점 : {total.Total(a,b,c)}");
            Console.WriteLine($"평균 : {total.Avg(a, b, c)}");
        }
    }
}
