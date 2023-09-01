using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _500p_예제
{
    delegate int MyDelegate(int a, int b);
    class Cal
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
            Cal cal = new Cal();
            MyDelegate Callback;

            Callback = cal.Plus;
            Console.WriteLine(Callback(3, 4));

            Callback = cal.Minus;
            Console.WriteLine(Callback(7, 5));
        }
    }
}

/*
namespace _500p_예제
{
    delegate int MyDelegate(int a, int b);
    internal class Program
    {
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static int Minus(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            MyDelegate Callback;

            Callback = Plus;
            Console.WriteLine(Callback(3, 4));

            Callback = Minus;
            Console.WriteLine(Callback(7, 5));
        }
    }
}
*/