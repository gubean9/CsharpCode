using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTest001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i;
            for (i = 100; i > 0; i--) //(초기값; 조건; 증가감)
            {
                ;
            }
            Console.WriteLine(i);
            */

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
