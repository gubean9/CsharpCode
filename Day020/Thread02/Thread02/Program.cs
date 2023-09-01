using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread02
{
    internal class Program
    {
        static void Run()
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("스레드 프로그램 종료");
        }
        static void Main(string[] args)
        {
            //Thread를 이용해서 1~100을 출력하는 프로그램
            Thread t = new Thread(new ThreadStart(Run));
            t.Name = "ThreadMK1";
            t.Start();
            t.Join(); //없으면 메인프로그램이 먼저 종료됨
            Console.WriteLine("Main 프로그램 종료");
        }
    }
}
