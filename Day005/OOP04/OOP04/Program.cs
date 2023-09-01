using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    class Cat
    {
        //멤버 변수 위에 둬도 ㄱㅊ
        //public string Name;
        //public string Color;

        //default 생성자
        public Cat()
        {
            this.Name = ""; //this. 생략가능
            Color = "";
        }
        //인자가 있는 생성자

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        //멤버 변수 아래쪽에 둬도 ㄱㅊ
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{this.Name} : 야옹"); //this 생략 가능
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");
            Console.WriteLine(kitty.Name + " " + kitty.Color);

            Cat nero = new Cat("네로", "검은색");
        }
    }
}
