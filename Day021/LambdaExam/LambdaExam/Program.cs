using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExam
{
    delegate int Calculate(int a, int b);
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Add(100, 200);
            Console.WriteLine("Class : " + sum);

            //Delegate 방식
            Calculate cal = (int a, int b) => a + b;
            sum = cal(100, 200);
            Console.WriteLine("Delegate : " + sum);
            //Calculate cal2 = (int x, int y) => x + y;

            //Func 방식
            Func<int, int, int> add = (x, y) => x + y;
            sum = add(10, 200);
            Console.WriteLine("Func : " + sum);
        }
    }
}
