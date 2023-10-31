using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());

            if(90 <= num && num <=100 )
            {
                Console.WriteLine("A");
            }
            else if(80 <= num && num <= 89)
            {
                Console.WriteLine("B");
            }
            else if(70 <= num && num <= 79)
            {
                Console.WriteLine("C");
            }
            else if(60 <= num && num <= 69)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
