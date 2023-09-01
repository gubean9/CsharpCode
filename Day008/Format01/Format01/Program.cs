using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("제목 : {0}", "이것이 C#이다");
            Console.WriteLine("Total : {0, 7:D}", 123);

            string result = string.Format("{0}DEF", "ABC");
            Console.WriteLine(result);

            string result2 = string.Format("{0,-10}DEF", "ABC");
            Console.WriteLine(result2);

            //104p 예제
            string fmt = "{0,-20}{1,-15}{2,30}";

            Console.WriteLine(fmt, "Publisher", "Author", "Title");
            Console.WriteLine(fmt, "순번", "이름", "나이");


            Console.WriteLine();

            Console.WriteLine("{0:D}", 255);
            Console.WriteLine("{0:D}", 0xFF);

            Console.WriteLine("{0:X}", 255);
            Console.WriteLine("{0:X}", 0xFF);

            Console.WriteLine("{0:N}", 12345678); //자동으로 콤마 찍어줌 자주 쓴다


            Console.WriteLine("{0:F}", 123.45);

            Console.WriteLine("{0,E}", 123.456789);
        }
    }
}
