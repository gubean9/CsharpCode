using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    abstract class Zoo
    {
        public abstract void Eat();
    }

    class Rabbit : Zoo
    {
        public override void Eat()
        {
            Console.WriteLine("토끼");
        }
    }
    class Monkey : Zoo
    {
        public override void Eat()
        {
            Console.WriteLine("원숭이");
        }
    }
    /*
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("사각형");
        }
    }
    //class Rectangle : Shape{} 이렇게 한 줄로 해도 됨
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Rabbit r = new Rabbit();
            Monkey m = new Monkey();

            r.Eat();
            m.Eat();

            /*
            Triangle t = new Triangle();
            Rectangle r = new Rectangle();

            t.Draw();
            r.Draw();
            */
        }
    }
}
