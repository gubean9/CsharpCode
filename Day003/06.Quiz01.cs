using System;

namespace SiteTest001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = Int32.Parse(Console.ReadLine());
            /*
            string a = "*";
            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
            */

            /*
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = num; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int i = 0; i < num; i++)
            {
                for (int j = (num - i - 1); j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < num; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = (num - i - 1); j >= 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            */

            /*
            int a = 5, b = 1;

            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= a - i; j++)
                {
                    Console.Write(" ");
                }

                for(int k = 1; k <= (b * i -1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
