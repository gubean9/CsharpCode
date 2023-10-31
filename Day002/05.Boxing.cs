using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a; //Boxing : 값 형식 => 참조 형식
            int c = (int)b; //Unboxing : 참조 형식 => 값 형식

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //객체가 되려면 new가 되어야 하는데 

            double x = 3.141592;
            object y = x;
            double z = (double)y;

            //기본타입에서 객체로 들어가는 것을 Boxing
            //객체값에서 기본타입으로 들어가는 것을 UnBoxing
        }
    }
}
