using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTest03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 0;
            do
            {
                Console.WriteLine("Hello");
                i++;
            }
            while (i < 5); //부등호 방향 잘 생각하기
            */
            //1. 무한루프를 do~while문으로 만듭니다
            //2. 정수 100을 넣으면 종료되는 프로그램
            //3. switch~case 문을 넣어 오전과 동일한 프로그램

            int a;
            do
            {
                Console.Write("숫자를 입력하세요 :");
                a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.WriteLine("1을 입력하셨습니다");
                        break;
                    case 2:
                        Console.WriteLine("2를 입력하셨습니다");
                        break;
                    case 100:
                        break;
                    default:
                        Console.WriteLine("1,2 이외의 숫자를 입력하셨습니다");
                        break;
                }

                if (a == 100)
                {
                    Console.WriteLine("숫자 100을 입력했으므로 종료합니다");
                    break;
                }
            }
            while (true);
            {
                
            }
        }
    }
}
