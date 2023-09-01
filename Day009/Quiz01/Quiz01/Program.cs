using System;

namespace Quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[80];

            Random r = new Random();

            int each;
            for (int i = 0; i < arr.Length; i++)
            {
                each = r.Next(1, 101);
                arr[i] = each;
            }

            //foreach (int score in arr)
            //{
            //    Console.Write(score + " ");
            //}

            //Console.WriteLine();

            if (Array.BinarySearch<int>(arr, 80) > 0)
            {
                Console.WriteLine($"80이 처음 등장한 위치는 " + Array.BinarySearch<int>(arr, 80));
                Array.Sort(arr);
                Console.WriteLine($"정렬 후 80이 처음 등장한 위치는 " + Array.BinarySearch<int>(arr, 80));
            }
            else
            {
                Console.WriteLine("값이 없습니다");
            }
        }
    }
}
