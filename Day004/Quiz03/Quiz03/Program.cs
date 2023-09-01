using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Quiz03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] resurlt = new int[,];

            for(int i = 0; i < resurlt.GetLength(0); i++)
            {
                for(int j = 0; j< resurlt.GetLength(1); j++)
                {
                    Console.Write(resurlt[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
