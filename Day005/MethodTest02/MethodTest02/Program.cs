using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest02
{
    class MyApp
    {
        public int Max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        public int Min(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }
    }

    internal class Program
    {
        //두 수를 입력받아 큰 수를 출력
        static void Main(string[] args)
        {
            MyApp app = new MyApp();
            int[] num = new int[2];
            for (int i = 0; i < num.Length; i++)
            {
                int a = int.Parse(Console.ReadLine());
                num[i] = a;
            }

            Console.WriteLine("큰 값 : " + app.Max(num[0], num[1]));
            Console.WriteLine("작은 값 : " + app.Min(num[0], num[1]));
        }
    }
}
