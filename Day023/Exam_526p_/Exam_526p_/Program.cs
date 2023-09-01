using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_526p_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //연습문제 01
            /*
            Func<int> func_1 = () => 10;
            Func<int, int> func_2 = (a) => a * 2;

            Console.WriteLine(func_1() + func_2(30));
            */

            //연습문제 02
            int[] array = { 11, 22, 33, 44, 55 };

            foreach(int a in array)
            {
                /*
                Action action = new Action
                (
                    delegate ()
                    {
                        Console.WriteLine(a * a);
                    }
                 );
                action.Invoke();
                */

                Action<int> act1 = (x) =>
                {
                    int result = x * x;
                    Console.WriteLine(result);
                };
                act1(a);
            }
        }
    }
}
