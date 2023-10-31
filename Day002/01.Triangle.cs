using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App006
{
    /*internal*/ class MainClass //internal이 있으나 없으나 운영체제가 알아서 판단
    {
        static void Main(string[] args)
        {
            /*int a, b, c;
            Console.WriteLine("높이를 입력하세요");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            c = a * b / 2;
            
            Console.WriteLine(c);
            */

            int width, height;
            double area;

            width = int.Parse(Console.ReadLine());
            height = int.Parse(Console.ReadLine());

            area = (double)(width * height) / 2.0; // 2.0; = (double)2;

            Console.WriteLine(area);
        }
    }
}
