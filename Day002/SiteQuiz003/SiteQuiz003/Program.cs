using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteQuiz003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());

            if(90 <= num && num <=100 )
            {
                Console.WriteLine("A");
            }
            else if(80 <= num && num <= 89)
            {
                Console.WriteLine("B");
            }
            else if(70 <= num && num <= 79)
            {
                Console.WriteLine("C");
            }
            else if(60 <= num && num <= 69)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
/*if ~ else 문을 이용하여



학점을 출력하는 프로그램을 만들어 봅시다.

100 ~ 90  A

89 ~ 80  B

79 ~ 70  C

69 ~ 60 D

59 이하는 F



------------------------------

87

B

-------------------------------

47

F

------------------------------

96

A
*/