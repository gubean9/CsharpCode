using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static double Add(double num, double num2)
        {
            return num + num2;
        }

        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = 200;

            //double result = value1 + value2;
            //정수는 4바이트 실수는 8바이트라서 묵시적으로 가능
            //정수 => 실수는 가능, 실수 => 정수 불가능

            double result = Add(num1, num2);

            Console.WriteLine(result);
            Console.WriteLine(Add(num1, num2));
        }
    }
}
