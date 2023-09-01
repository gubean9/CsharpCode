using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class cat
    {
        //이름
        public string Name;
        //색
        public string Color;
        //나이
        public string Age;

        //생성자는 매우 독특한 메소드다
        public cat() //defualt 생성자
        {
            //초기화
            this.Name = "야옹이";
            this.Age = "2";
            this.Color = "누렁이";
        }

        //메소드 "야옹"
        public void Meow()
        {
            Console.WriteLine("야옹~!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //객체 생성
            cat kitty = new cat();
            //생성 후 초기화
            //kitty.Name = "kitty";
            //kitty.Age = "10";

            Console.WriteLine($"이름은 : {kitty.Name} 나이는 : {kitty.Age}");
        }
    }
}
