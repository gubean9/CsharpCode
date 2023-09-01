using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> que = new Queue<string>();
            que.Enqueue("Hello");
            que.Enqueue("Halo");
            que.Enqueue("Hi");

            //for (int i = 0; i < 3;  i++)
            //{
            //    string a = Console.ReadLine();
            //    que.Enqueue(a);
            //}
            
            while(que.Count > 0)
                Console.WriteLine(que.Dequeue());

            Console.WriteLine();

            //Stack으로 만들기
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);

            while(stack.Count > 0)
                Console.WriteLine(stack.Pop());

            Console.WriteLine();

            Stack<string> Reverse = new Stack<string>();
            Reverse.Push("H");
            Reverse.Push("E");
            Reverse.Push("L");
            Reverse.Push("L");
            Reverse.Push("O");

            while (Reverse.Count > 0)
                Console.Write(Reverse.Pop());

            Console.WriteLine();
        }
    }
}
