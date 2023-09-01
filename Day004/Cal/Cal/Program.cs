using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    class Calculator
    {
        //멤버변수
        //생성자
        //멤버메소드
        public int Plus(int a, int b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int resurlt = cal.Plus(100, 200);
            Console.WriteLine(resurlt);
        }
    }
}
