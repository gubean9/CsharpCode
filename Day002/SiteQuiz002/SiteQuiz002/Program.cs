using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteQuiz002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            c = b;
            b = a;
            a = c;

            Console.WriteLine($"{a} {b}");
        }
    }
}
/*두 정수 변수를 입력 받아 출력합니다.



단, cout 의 출력 순서를 변경하지 않고 출력하셔야 합니다.



///입력부



// 코드를 입력하세요.



Console.WriteLine($"{a} {b}");

-------------------------------------------------

100 200



200 100

*/