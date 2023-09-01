using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz04
{
    internal class Program
    {
        class Cal
        {
            public int Fac(int num)
            {
                int result = 1;
                for (int i = 2; i <= num; i++)
                {
                    result *= i;
                }

                return result;
            }

            public int FactorialRecursive(int n)
            {
                if (n == 0)
                    return 1;
                else
                    return n * Fac(n - 1);
            }

        }
        static void Main(string[] args)
        {
            int number = 5;
            Cal cal = new Cal();
            int fact = cal.Fac(number);
            Console.WriteLine($"{number}의 팩토리얼 : {fact}");

            fact = cal.FactorialRecursive(number);
            Console.WriteLine($"{number}의 재귀적 팩토리얼 : {fact}");
        }
    }
}
