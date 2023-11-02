/*
using System;

namespace RandomTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0과 1사의 무작위 실수
            //Random rand = new Random();
            //double n;
            //for (int i = 0; i < 5; i++)
            //{
            //    n = rand.NextDouble();
            //    Console.Write(n + "\t");
            //}
            //Console.WriteLine();


            //특정 범위의 정수
            Random r = new Random();
            int num2;
            /*
            Console.Write("로또번호 : ");
            for (int i = 0; i < 6; i++)
            {
                num2 = r.Next(1, 46); // 1부터 45까지 생성됨
                Console.Write(num2 + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"보너스번호 : {r.Next(1,46)}");
            */
            

            int[] arr = new int[7];
            Console.Write("로또번호 : ");
            for (int i = 0; i < 6; i++)
            {
                num2 = r.Next(1, 46); // 1부터 45까지 생성됨
                arr[i] = num2;
                Console.Write(arr[i] + " ");

                /*
                for(int j = 0; j < 7; j++)
                {
                    
                    if (arr[j] == num2)
                    {
                        Console.Write(num2 + " ");
                    }
                }
                */
            }
        }
    }
}
*/

// 풀이
using System;

namespace RandomTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int num;
            int[] lottoNumbers = new int[6];

            // 1단계
            Console.Write("로또번호 : ");
            for (int i = 0; i < 6; i++)
            {
                num = r.Next(1, 46); // 1부터 45까지 생성됨
                lottoNumbers[i] = num;
                Console.Write(lottoNumbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"보너스번호 : {r.Next(1, 46)}");

            // 2단계
            Array.Sort(lottoNumbers);
            Console.Write("로또번호 : ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(lottoNumbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"보너스번호 : {r.Next(1, 46)}");
        }
    }
}
