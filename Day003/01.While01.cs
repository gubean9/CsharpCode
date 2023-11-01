using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 1; i <= 100; i++) // (초기값; 조건; 증가감)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            int i = 1;
            while (i <= 100) // 1부터 100까지 반복
            {
                if (i % 2 == 0) // i가 2로 나누어 떨어지는 짝수인지 확인
                {
                    Console.WriteLine(i); // 짝수를 출력
                }
                i++; // i를 1씩 증가시킴
            }
        }
    }
}
