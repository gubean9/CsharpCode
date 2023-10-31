using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = Int32.Parse(Console.ReadLine());
            int age = 2023 - year;

            Console.WriteLine(age+1);
            Console.WriteLine(age);
        }
    }
}
