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
            Console.Write("1~7 사이의 숫자를 입력하세요 : ");
            int i = int.Parse(Console.ReadLine());

            if (i == 1 || i == 3 || i == 5)
            {
                Console.WriteLine("Enjoy!");
            }
            else
                Console.WriteLine("Oops");
        }
    }
}
