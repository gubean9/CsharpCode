using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz04
{
    internal class Program
    {
        static int Plus(int a, int b)
        {
            int P_result = a + b;
            return P_result;
        }
        static int Minus(int a, int b)
        {
            int M_result = a - b;
            return M_result;
        }
        static int Multiple(int a, int b)
        {
            return a * b;
        }
        static double Divide(int a, int b)
        {
            return a / (double)b;
        }
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int P_resurlt = Plus(a, b);
            int M_resurlt = Minus(a, b);
            int Mt_resurlt = Multiple(a, b);
            double D_resurlt = Divide(a, b);

            Console.WriteLine(P_resurlt);
            Console.WriteLine(M_resurlt);
            Console.WriteLine(Mt_resurlt);
            Console.WriteLine(D_resurlt);
        }
    }
}
/*
 static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine()); 
            int number2 = int.Parse(Console.ReadLine());
            int result1, result2, result3
            double result4;  //함정!!!
 
            result1 = plus(number1, number2);
            result2 = minus(number1, number2);
            result3 = multiple(number1, number2);
            result4 = divide (number1, number2);       

            Console.WriteLine(result1);
            Console.WriteLine(result2); 
            Console.WriteLine(result3); 
            Console.WriteLine(result4); 
        }
*/
