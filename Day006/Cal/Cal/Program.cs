using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    //사칙연산을 하는 계산기 만들기
    class Dog
    {
        public string Name
        {
            get; set;
        }
        //메소드
        public Dog(string _name)
        {
            Name = _name;
        }
        public string Eat()
        {
            return "먹습니다";
        }
        public string Play()
        {
            return "뛰어놀다";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog tom = new Dog("톰");

            Console.WriteLine($"{tom.Name}이 음식을 {tom.Eat()}");
            Console.WriteLine($"{tom.Name}이 {tom.Play()}");

        }
    }
}
