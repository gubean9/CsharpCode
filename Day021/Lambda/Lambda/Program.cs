using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    delegate int Calculate(int a, int b);
    internal class Program
    {
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static int Minus(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Calculate cal2 = new Calculate(Plus);
            cal2 = new Calculate(Minus);

            Calculate cal = (int a, int b) => a + b; //람다식 예시
            cal = (int a, int b) => a - b; //람다식 예시
            //람다식 쓰는 이유 : 짧고 간결해서~
        }
    }
}
