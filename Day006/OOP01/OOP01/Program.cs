using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    class Cal
    {
        public int Plus(int x, int y)
        {
            return x + y;
        }
        public int Plus(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        public double Plus(double x, double y)
        {
            return x + y;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Cal cal = new Cal();

            Console.WriteLine(cal.Plus(100, 200));
            Console.WriteLine(cal.Plus(100, 200, 300, 400));
            Console.WriteLine(cal.Plus(3.3, 2.2));
        }
    }
}
//오버로딩(overloading) / 다형성
//1. 정수 두 개를 합산하는 Plus 메소드
//2. 정수 네 개를 합산하는 Plus 메소드
//3. double 두 개를 합산하는 Plus 메소드