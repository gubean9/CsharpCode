using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App004
{
    class Program
    {
        static void Hello()
        {
            Console.WriteLine("안녕하세요");
        }

        void Hello2()
        {
            Console.WriteLine("반갑습니다");
        }

        static void Main(string[] args)
        {
            Hello();
            Program p = new Program();
            p.Hello2();
        }
    }
}
