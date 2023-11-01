using System;

namespace Quiz02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] % 2 != 0)
                {
                    Console.Write(arr[j] + " ");
                }
            }
            Console.WriteLine();

            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k] % 3 == 0)
                {
                    Console.Write(arr[k] + " ");
                }
            }

            /* 이게 더 좋음
            for(int i = 0; i < arr.Length; i+= 3)
                Console.Write(arr[i] + " ");
             */
        }
    }
}
