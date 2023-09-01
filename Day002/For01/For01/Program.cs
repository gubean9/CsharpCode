using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i = 0;
            for(i=0; i<3; i++)
            {
                Console.WriteLine("냠");
            }
            */

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i+1);
            }
            //Console.WriteLine(i); //Scope 스텍 메모리가 중괄호 안에 있어서 안됨~~
        }
    }
}
