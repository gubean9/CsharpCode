using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = num; j > i; j--)
            //        Console.Write(" ");

            //    for (int k = 0; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                for(int j = num; j > i; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
