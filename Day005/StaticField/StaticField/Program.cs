using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticField
{
    class Global
    {
        public static int Count = 0; //공용 변수
    }
    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }
    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Global Count : {Global.Count}");

            ClassA ca1 = new ClassA(); //이퀄 앞 생략가능
            ClassA ca2 = new ClassA();
            new ClassA();
            new ClassA();


            Console.WriteLine($"Global Count : {Global.Count}");
        }
    }
}
