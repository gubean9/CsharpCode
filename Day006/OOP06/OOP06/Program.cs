using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06
{
    //도형(부모) 클래스 만들기
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("도형");
        }
    }
    //삼각형(자식) 클래스 만들기 (상속)
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형");
        }
    }
    //사각형(자식)
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("사각형");
        }
    }
    //원(자식)
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("원");
        }
    }
    //공통메소드 draw()를 구현하고 각 클래스에서 오버라이딩
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            s1.Draw();
            Shape s2 = new Triangle();
            s2.Draw();
            Shape s3 = new Rectangle();
            s3.Draw();
            Shape s4 = new Circle();
            s4.Draw();
        }
    }
}
