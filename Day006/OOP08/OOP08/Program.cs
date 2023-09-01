using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP08
{
    abstract class Shape
    {
        public abstract void Draw();
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형을 그리다");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            t.Draw();

            Shape s = new Triangle();
            s.Draw();
        }
    }
}
