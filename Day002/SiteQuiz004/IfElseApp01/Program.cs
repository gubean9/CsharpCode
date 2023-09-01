using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = 62;
            //입력부 만들기
            int number = Int32.Parse(Console.ReadLine());


            if(number % 2 == 1) //number%2 != 0 
            {
                Console.WriteLine("홀수");
            }
            else
            {
                Console.WriteLine("짝수");
            }

            if(number > 0)
            {
                Console.WriteLine("양수");
            }
            else
            {
                Console.WriteLine("음수");
            }
        }
    }
}
