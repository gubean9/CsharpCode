using System;

namespace WhileTest02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* while문을 사용해 1~100 사이의 숫자 중 홀수를 찾아 출력하는 코드
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            */


            /* 1~100 사이의 숫자 중 13의 배수만 출력하는 코드
            for (int i = 1; i <= 100; i++)
            {
                if (i % 13 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            int i = 1;
            while (i <= 100) // 1부터 99까지 반복
            {
                if (i % 13 == 0) // i가 13으로 나누어 떨어지는지 확인
                {
                    Console.WriteLine(i); // 13의 배수를 출력
                }
                i++; // i를 1씩 증가시킴
            }
        }
    }
}
