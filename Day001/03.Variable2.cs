using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //숫자 2개 더하기
            //1. 변수 선언 & 입력
            int a, b;
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            //2. 로직
            int result = a+ b;
            //3. 출력
            Console.WriteLine(result);
            */


            //문제 : 가로(width), 세로(height)를 입력받아 넓이를 구하기
            //단, 입력은 정수로 계산
            int width, height;
            width = int.Parse(Console.ReadLine());
            height = int.Parse(Console.ReadLine());
            int result = width * height;
            Console.WriteLine(result);
        }
    }
}
