using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            /*for (int i = 0; i < 100; i++)
            {
                sum += i + 1;
            }
            Console.WriteLine(sum);
            */

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
