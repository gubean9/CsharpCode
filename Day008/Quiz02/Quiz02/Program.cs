using System;

namespace Quiz02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("문자를 입력하세요 : ");
            string st = Console.ReadLine();

            int a = 0, b = 0, c = 0, d = 0;

            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] >= 'A' && st[i] <= 'Z')
                    a++;

                else if (st[i] >= 'a' && st[i] <= 'z')
                    b++;

                else if (st[i] >= '0' && st[i] <= '9')
                    c++;

                else
                    d++;
            }
            Console.WriteLine($"알파벳 대문자 : {a}");
            Console.WriteLine($"알파벳 소문자 : {b}");
            Console.WriteLine($"숫자 : {c}");
            Console.WriteLine($"특수문자 : {d}");

            /*
            if(a == )
            for(int i = 0; i < a.Length; i++)
            {
                if()
            }
            */
        }
    }
}
