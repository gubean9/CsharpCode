using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtoF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;
            a = Int32.Parse(Console.ReadLine());
            b = 9.0 / 5 * a + 32;

            Console.WriteLine(b);

            /*int width, height;
            double area;

            width = int.Parse(Console.ReadLine());
            height = int.Parse(Console.ReadLine());

            area = (double)(width * height) / 2.0; // 2.0; = (double)2;

            Console.WriteLine(area);
            */
        }
    }
}
