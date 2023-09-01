using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetBytes(); //외우기!!


            Console.Write("실수를 입력하세요 : ");
            double a = double.Parse(Console.ReadLine());

            byte[] doubleBytes = BitConverter.GetBytes(a); //필수

            double result = BitConverter.ToDouble(doubleBytes, 0);

            Console.WriteLine(BitConverter.ToString(doubleBytes));
            Console.WriteLine(result);
        }
    }
}
