using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass NewCopy = new MyClass();
            NewCopy.MyField1 = MyField1;
            NewCopy.MyField2 = MyField2;

            return NewCopy;
        }
    }

    /*
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
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass source = new MyClass();
            source.MyField1 = 10;
            source.MyField2 = 20;

            //MyClass target = source;
            MyClass target = source.DeepCopy();
            target.MyField2 = 30;

            Console.WriteLine(source.MyField1 + " " + source.MyField2);
            Console.WriteLine(target.MyField1 + " " + target.MyField2);

            /*
            MyClass source = new MyClass(); //new MyClass는 쓸 때마다 달라짐~!
            source.MyField1 = 10;
            source.MyField2 = 20;

            //MyClass target = new MyClass();
            //MyClass target = source;
            MyClass target = source.DeepCopy();
            target.MyField2 = 30;

            Console.WriteLine(source.MyField1 + " " + source.MyField2);
            Console.WriteLine(target.MyField1 + " " + target.MyField2);
            */
        }
    }
}
