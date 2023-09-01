using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable229p
{
    class SomeClass
    {
        public void SomeMethod()
        {
            int count = 0;
            Local(1, 2);
            Local(3, 4);

            void Local(int a, int b)
            {
                //Do some work
                Console.WriteLine($"sount : {++count}");
            }
        }
        
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            SomeClass sc = new SomeClass();
            sc.SomeMethod();
        }
    }
}
