using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i = 0;

            while(i <= 5)
            {
                Console.Write(i + " ");
                //i = i + 1;
                //i += i;
                i++; // 후치 연산자(++i로 써도 똑같음)
            }
            */

            int i = 1; //초기값

            while (i <= 200) //조건
            {
                Console.Write(i + " ");
                i++; //증가값
            }
        }
    }
}
