using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest01
{
    internal class Program
    {
        /*
        void Hello() //기왕이면 static을 붙이지 않고 만들기
        {
            Console.WriteLine("Hello World");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Hello();
        }

        static void Hello() //기왕이면 static을 붙이지 않고 만들기
        {
            Console.WriteLine("Hello World");
        }

        static void Main(string[] args)
        {
            Hello();
        }


        int Plus(int n1, int n2)
        {
            return n1 + n2;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Plus(1, 2));
        }
        */
        double Avg(int kor, int eng, int math)
        {
            return (kor + eng + math)/3.0;

            /*
            int total = kor + eng + math;
            return (double)total / 3.0;
            */
        }

        static void Main(string[] args)
        {
            //int kor, eng, math;
            int[] score = new int[3];

            for(int i = 0; i < 3; i++)
            {
                score[i] = int.Parse(Console.ReadLine());
            }

            /*
            kor = int.Parse(Console.ReadLine());
            eng = int.Parse(Console.ReadLine());
            math = int.Parse(Console.ReadLine());
            */

            Program p = new Program(); //이걸 하는 이유가 뭘까 궁금함
            double resurlt = p.Avg(score[0], score[1], score[2]);
            Console.Write(resurlt);
        }
    }
}
