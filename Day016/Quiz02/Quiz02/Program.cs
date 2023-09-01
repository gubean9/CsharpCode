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
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    for(int  k = 0; k < 3; k++)
                    {
                        if(i != j && j != k && k != i)
                        {
                            Console.WriteLine($"{i+1} {j+1} {k+1}");
                        }
                    }
                }
            }
        }
    }
}
