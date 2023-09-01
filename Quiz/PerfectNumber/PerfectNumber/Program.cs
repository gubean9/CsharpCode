using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int num = 10;

            for(int i = 1; i < num; i++)
            {
                if(num % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            //여기까지 약수 구하는 프로그램
        }
    }
}
