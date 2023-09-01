using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz02
{
    internal class Program
    {
        //class Cal
        //{
        //    public int Cal(int x, int y)
        //    {
        //        return;
        //    }
        //}

        static int Pow(int x, int y)
        {
            int result = 1;
            for(int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
        static void Main(string[] args)
        {
            /*
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            for(int i = 0; i < y; i++)
            {
                for(int j = 1; j < y; j++)
                {
                    x = y * y;
                }
            }
            Console.WriteLine(x);

            for(int i = 1; i < y; i++)
            {
                //x를 y만큼 거듭제곱한다
            }
            */

            int x = 2;
            int y = 10;

            int result = Pow(x, y);
            Console.WriteLine(result);
        }
    }
}
