using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest
{
    class Program
    {
        //멤버 변수
        enum DigitalResult { YES, NO, CONFIRM, OK }

        static void Main(string[] args)
        {
            Console.WriteLine(DigitalResult.YES);
            Console.WriteLine((int)DigitalResult.YES);

            Console.WriteLine(DigitalResult.OK);
            Console.WriteLine((int)DigitalResult.OK);
        }
    }
}
