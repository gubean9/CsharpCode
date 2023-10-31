using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteQuiz002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            c = b;
            b = a;
            a = c;

            Console.WriteLine($"{a} {b}");
        }
    }
}
