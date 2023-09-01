using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate01
{
    delegate int MyDelegate(int a, int b); //함수처럼 선언/사용 됨

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator Cal = new Calculator();
            MyDelegate Callback;

            /*
            //MyDelegate my = Cal.Plus;
            Callback = new MyDelegate(Cal.Plus); //callback이 더하기 기능이 됨
            Console.WriteLine(Callback(5, 10));

            Callback = new MyDelegate(Cal.Minus);
            Console.WriteLine(Callback(5, 10));
            */

            Console.WriteLine(new MyDelegate(Cal.Plus)(5, 10));
        }
    }
}
