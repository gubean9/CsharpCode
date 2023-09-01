using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1~10 정수형 배열 arr 선언
            int[] arr = new int[10];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
                Console.Write(arr[i] + " ");
            }
        }
    }
}