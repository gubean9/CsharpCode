using System;

namespace WhileTest002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i = 0;
            while (i < 100)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }*/

            for (int i = 1; i < 100; i++)
            {
                if (i % 13 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}