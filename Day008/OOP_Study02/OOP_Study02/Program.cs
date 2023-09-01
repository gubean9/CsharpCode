using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Study02
{
    class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape 생성자가 호출됨");
        }
        public virtual void Draw()
        {
            Console.WriteLine("그리다");
        }
        public virtual void Draw(string pen)
        {
            Console.WriteLine(pen + "그리다");
        }
        public virtual int Draw(string pen, int v)
        {
            Console.WriteLine(pen + "그리다" + "굵기는" + v);
            return v;
        }

    }
    class Triangle : Shape
    {
        //1. 멤버 변수
        //2. 생성자
        public Triangle()
        {
            Console.WriteLine("Triangle 생성자가 호출됨");
        }

        //3. 멤버 메소드
        //부모 클래스에 __가 있는데 자식 클래스에서 재정의하고 싶으면 호출 붙이고 이게 오버라이딩~...임
        public override void Draw()
        {
            base.Draw();
        }

        public override void Draw(string pen)
        {
            base.Draw(pen);
        }

        public override int Draw(string pen, int v)
        {
            return base.Draw(pen, v);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Triangle();
            //부모 => 자식으로 포인트는 가능한데 그 반대는 불가

            int a = 100;
            double b = 100.3;

            b = a; //더 큰 값이 묵시적으로 잡아먹는다고????하는?듯?? 
            a = (int)b;
        }
    }
}
