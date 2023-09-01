using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            Console.WriteLine(a);
            Console.WriteLine(b);

            //Console.WriteLine(int(a)); 불가능

            object c = 123; //사용자 정의 타입(class)
            Console.WriteLine(c);

            object d = 3.141592;
            Console.WriteLine(d);

            object e = "안녕하세요";
            Console.WriteLine(e);

            //Boxing, Unboxing
            object f = 20;
            int g = 123;
            int h = (int)f; //강제형변환하면 들어감
        }
    }
}
