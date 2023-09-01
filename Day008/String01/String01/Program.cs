using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string greeting = "Good Morning";

            Console.WriteLine(greeting.Substring(0,5));
            Console.WriteLine(greeting.Substring(5));
            Console.WriteLine();

            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None); //많이 씀, 암기하기


            foreach(string element in arr)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(arr[0] + " " + arr[1]);
            */

            /*
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            foreach (int num in arr)
                Console.Write(num + " ");
            */

            string[] arr = { "안녕", "하세요 ", "반갑", "습니다" };

            foreach(string s in arr)
                Console.Write(s);
        }
    }
}
