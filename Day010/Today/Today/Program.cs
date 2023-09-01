using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today
{
    //유니콘 => 말 + 날개
    interface IWing //객체지향적인 의미로는 Flyable같은 이름으로 설정한다고 함
    {
        void fly();
    }
    
    class Angel
    {

    }
    class Horse
    {

    }
    class Unicorn : Horse, IWing
    {
        public void fly()
        {
            //내가 자유롭게 코딩합니다.
            Console.WriteLine("FlY");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Unicorn u = new Unicorn();
            u.fly();
        }
    }
}
