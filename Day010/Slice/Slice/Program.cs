using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slice
{
    internal class Program
    {
        //시간을 줄이려면 타입 지정해주는 것이 좋음
        //타입 스크립트! 
        static void PrintArray(System.Array array) //System.Array로 하면 모든 타입이 가능
        {
            foreach (char c in array) //char => var로 변경해도 가능
                Console.Write(c + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //배열 선언
            char[] array = new char['Z' - 'A' + 1]; //A = 65, Z = 90 (90 - 65 + 1) = 26(개)

            //배열 초기화
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = (char)('A' + i);
            }

            PrintArray(array);

            //foreach (char c in array)
            //{
            //    Console.WriteLine(c);
            //}
        }
    }
}
