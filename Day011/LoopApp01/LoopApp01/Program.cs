using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopApp01
{
    class Calculator
    {
        public int SumLoop(int a, int b) //int a,b 보다는 from to, 한국에서는 start end 형식을 주로 사용
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = SumLoop(a, b);
            */
            Calculator cal = new Calculator();
            int result = cal.SumLoop(1, 100);
            Console.WriteLine(result);
        }
    }
}
