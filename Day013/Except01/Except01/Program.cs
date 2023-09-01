using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//451p 예제
namespace Except01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //일반적인 코드
            int[] arr = { 1, 2, 3 };

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("종료");
            */

            //454p 예제
            int[] arr = { 1, 2, 3 };

            try
            {
                /*
                //1.예외
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                */

                int a = 100;
                int result = a / 0;
            }
            //예외 여러 개 나누기 가능함
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("배열의 범위를 벗어난 예외가 발생하였습니다");
                Environment.Exit(0);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("0으로 나눌 수 없습니다");
                Environment.Exit(0);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

            Console.WriteLine("종료");
        }
    }
}
