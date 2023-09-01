using System;

namespace ArrayTest02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1~10까지 배열에 홀수만 입력되는 5개짜리 arr 배열
            int[] arr = new int[5];

            /*
            int cnt = 1; // Flag 또는 Count 변수를 사용할 수 있는가?

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = cnt;
                cnt += 2;

                Console.Write(arr[i] + " ");
            }
            */

            for (int i = 0, cnt = 1; i < arr.Length; i++)
            {
                arr[i] = cnt;
                cnt += 2;

                Console.Write(arr[i] + " ");
            }
        }
    }
}
