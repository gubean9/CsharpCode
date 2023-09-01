using System;
using System.Linq.Expressions;

namespace Quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //약수의 개수가 짝수인 수의 개수를 출력

            //string st = Console.ReadLine();
            //int[] st = new int[100];

            Console.Write("첫 번째 숫자 : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("두 번째 숫자 : ");
            int b = int.Parse(Console.ReadLine());

            int num = 0, num2 = 0;

            for(int i = a; i < b; i++)
            {
                for(int j = 1; j < i; j++)
                {
                    if (i % 2 == 0)
                    {
                        num++;
                    }
                }
                if (num % 2 == 0)
                {
                    num2++;
                    num = 0;
                }
            }
            
            /*
            for (int i = a; i < b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (i % 2 == 0)
                        num++;
                }
                if (num % 2 == 0)
                    num2++;
                num = 0;
            }
            */

            Console.WriteLine("약수의 개수가 짝수인 수는 " + num2 + "개 입니다");
        }
    }
}
