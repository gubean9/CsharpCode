using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteQuiz005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = Int32.Parse(Console.ReadLine());
            int age = 2023 - year;

            Console.WriteLine(age+1);
            Console.WriteLine(age);
        }
    }
}
/*Q : 태어난 연도를 입력하면 한국 나이를 출력해주는 프로그램 작성
 
 --------------
 1999
 25
 만24세
*/