using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        class MyClass
        {
            public int MyField1;
            public int MyField2;

            public MyClass DeepCopy()
            {
                MyClass newCopy = new MyClass();
                newCopy.MyField1 = MyField1;
                newCopy.MyField2 = MyField2;

                return newCopy;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("얕은 복사");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine(source.MyField1 + " " + source.MyField2);
                Console.WriteLine(target.MyField1 + " " + target.MyField2);
            }

            {
                Console.WriteLine();
                Console.WriteLine("깊은 복사");

                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                //MyClass target = source;
                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine(source.MyField1 + " " + source.MyField2);
                Console.WriteLine(target.MyField1 + " " + target.MyField2);
            }
        }
    }
}
