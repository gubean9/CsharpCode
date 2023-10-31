using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            Console.WriteLine("Type:{0}, Value:{1}", a.GetType(), a); // a의 타입과 값을 각각 출력
            Console.WriteLine($"Type:{a.GetType()}, Value:{a}");
        }
    }
}
