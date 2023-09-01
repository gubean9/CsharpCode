using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string은 꼭 마지막에 NUL에 들어감~...
            string[] input = Console.ReadLine().Split(' ');
            int[,] arr = new int[3, 4];

            //여기가 중요함
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    arr[i, j] = int.Parse(input[i * 4 + j]);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int j = 0; j < 3; j++)
            {
                for(int i = 0; i < 4; i++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
