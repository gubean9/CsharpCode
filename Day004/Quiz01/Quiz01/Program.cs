using System;

namespace Quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[] arr = new char[26];
            char[] arr2 = new char[26];

            char ch = 'Z';
            char ch2 = 'a';

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ch--;
                arr2[i] = ch2++;
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr2[j] + " ");
            }
        }
    }
}
