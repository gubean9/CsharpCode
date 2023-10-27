using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //기본 자료형 1byte(8bit)
            sbyte a = 127; //-128 ~ 127
            byte b = 255; //0~255

            Console.WriteLine($"a = {a}, b = {b}");
            //Console.WriteLine("a = " + a);

            short c = -32768; //-32,768 ~ 32,767
            ushort d = 65535; //0 ~ 65535

            Console.WriteLine($"c = {c}, d = {d}");

            int e = -2147483648;
            uint f = 4294967295;

            Console.WriteLine($"e = {e}, f = {f}");

            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000_0000;

            Console.WriteLine($"g = {g}, h = {h}");

            byte i = 240; //240 => 리터럴(고정된 변수 / 소스 코드에 직접 포함된 고정된 값 자체)
        }
    }
}
