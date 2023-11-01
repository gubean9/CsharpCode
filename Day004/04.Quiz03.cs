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
            int[,] arr = new int[8, 9];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    arr[i, j] = (i + 2) * (j + 1);
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
