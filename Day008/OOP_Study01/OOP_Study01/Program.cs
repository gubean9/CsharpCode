using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Study01
{
    class Point //클래스 이름이 같으면 오류 남~
    {
        public int x; //C#은 자동으로 기본타입은 초기화를 해줌
        public int y;

       //생성자의 역할은 객체의 초기화
        public Point()
        {
            x = 1;
            y = 2;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            //괄호의 x와 중괄호의 x는 서로 다름 
        }
    }
    /*
    class Shape
    {
        //1. 멤버 변수
        //2. 생성자
        //3. 멤버 메소드
    }
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 3;
            int y = 5;

            Console.WriteLine($"x좌표는 {x} y좌표는 {y}");
            */

            Point pt1 = new Point();
            Console.WriteLine($"({pt1.x},{pt1.y})");

            Point pt2 = new Point(3, 5);
            Console.WriteLine($"({pt2.x},{pt2.y})");
            //sibal... moranungoim
        }
    }
}
