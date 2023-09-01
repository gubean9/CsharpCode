using System;

namespace 백준
{
    internal class Program
    {
        static void Main()
        {
            //배열에 2자리 숫자를 입력하면 그걸 반으로 갈라서 두 숫자를 더하는 프로그램
            int[] a = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);
        }
    }
}
