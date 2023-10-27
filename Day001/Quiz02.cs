using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*char[] greet = new char[3]; //리스트 사용
            greet[0] = '반';
            greet[1] = '가';
            greet[2] = '워';
            for (int i = 0; i < greet.Length; i++)
            {
                Console.WriteLine(greet[i]);
            }*/

            char a = '반';
            char b = '가';
            char c = '워';

            Console.WriteLine($"{a}{b}{c}");

            string d = "행복\n하세\n요!!!";

            Console.WriteLine(d);
        }
    }
}


