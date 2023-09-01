using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface01
{
    interface Wing
    {
        //public void Fly(); 사용불가 public 한정자가 유효하지 않다고 뜸
        void Fly();
    }
    class Horse
    {

    }

    class Angel : Wing
    {
        public void Fly()
        {
            Console.WriteLine("천사가 날다");
        }
    }

    //C++은 다중 상속이 가능하지만 C#은 다중 상속이 불가
    //interface는 상속이 안 되는데도 상속처럼 사용 가능
    class Unicorn : Horse, Wing
    {
        public void Fly()
        {
            Console.WriteLine("유니콘이 날다");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Angel angel = new Angel();
            angel.Fly();
            Unicorn unicorn = new Unicorn();
            unicorn.Fly();
        }
    }
}
