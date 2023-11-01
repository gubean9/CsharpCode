using System;

namespace Quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[] BigAlpha = new char[26];
            char[] SmallAlpha = new char[26];

            char ch = 'Z';
            char ch2 = 'a';

            for (int i = 0; i < BigAlpha.Length; i++)
            {
                BigAlpha[i] = ch--;
                SmallAlpha[i] = ch2++;
                Console.Write(BigAlpha[i] + " ");
            }
            Console.WriteLine();

            for (int j = 0; j < BigAlpha.Length; j++)
            {
                Console.Write(SmallAlpha[j] + " ");
            }
        }
    }
}
