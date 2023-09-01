using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1번
            string input = Console.ReadLine();

            string reversed = "";
            for(int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            Console.WriteLine(reversed);


            /*
            //2번
            string input = Console.ReadLine();

            char[] array = input.ToCharArray();
            Array.Reverse(array);
            string reversed = new string(array);

            Console.WriteLine(reversed);
            */

            /*
            //3번
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>(input);
            string reversed = string.Join("", stack);

            Console.WriteLine(reversed);
            */

            /*
            //4번
            string input = Console.ReadLine();
            string reversed = new string(input.Reverse().ToArray());
            Console.WriteLine(reversed);
            */

            /*
            string[] a = Console.ReadLine();

            for(int i = a.Length - 1; i > 0; i--)
            {
                Console.WriteLine(a[i]);
            }
            */
        }
    }
}
