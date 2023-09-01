using System;

namespace SiteQuiz05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0, cnt = 70; i < arr.Length; i++, cnt -= 7)
            {
                arr[i] = cnt;
                Console.Write(arr[i] + " ");
            }
        }
    }
}