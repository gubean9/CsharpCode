using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapRef
{
    internal class Program
    {
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"{a} {b}");
        }
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;

            Console.WriteLine($"{x} {y}");

            swap(ref x, ref y);
        }
    }
}
