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
            bool flag = false;
            for(int i = 2; i <= 100; i++)
            {
                flag = false;
                for(int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                    Console.Write(i + " ");
            }
            

            /*
            int num = 100;
            for(int i = 2; i * i < num; i++)
            {
                if (i % num != 0) { }
                    Console.Write(i);
            }
            */
        }
    }
}
//X가 주어졌을 때 2부터 X-1까지 전부 나눠보기
//한 번이라도 나눠 떨어지면 탈출