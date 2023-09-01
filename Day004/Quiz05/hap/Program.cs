using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hap
{
    internal class Program
    {
        static int Plus(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        static void Main(string[] args)
        {
            //int a = Int32.Parse(Console.ReadLine());
            //int b = Int32.Parse(Console.ReadLine());
            //int c = Int32.Parse(Console.ReadLine());
            //int d = Int32.Parse(Console.ReadLine());

            Console.Clear(); //안해도 ㄱㅊ음
            string[] input = Console.ReadLine().Split(' ');

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int d = int.Parse(input[3]);

            /*
            int e = Plus(a, b, c, d);
            Console.WriteLine(e);
            */

            Console.WriteLine(Plus(a, b, c, d));
        }
    }
}
