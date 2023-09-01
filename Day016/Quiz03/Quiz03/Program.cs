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
            int[] arr = {1, 2, 3};
            for(int i = 0; i < 3; i++)
            {
                int a = arr[i];
                for(int j =  0; j < 3; j++)
                {
                    int b = arr[j];
                    for(int k = 0; k < 3; k++)
                    {
                        int c = arr[k];
                        if(i != j && j != k && k != i)
                        {
                            Console.WriteLine($"{a} {b} {c}");
                        }
                    }
                }
            }
        }
    }
}
