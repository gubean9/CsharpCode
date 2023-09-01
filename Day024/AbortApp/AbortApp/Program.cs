using System;
using System.Threading;

namespace AbortApp
{
    internal class Program
    {
        static void DoSomething()
        {
            try
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.WriteLine($"DoSomething : {i}");
                    Thread.Sleep(10); //0.01초 딜레이~ 0.05초(200)정도 기다려야 다음 클락을 받아주는 장치가 있음
                                      //Sleep 말고 딜레이 사용하는 게 좋음
                }
            }
            catch (ThreadAbortException)
            {
                Console.WriteLine("스레드 Abort 발생");
            }
            finally
            {
                //무조건 실행되는 구문
                Console.WriteLine("finally");
            }

        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(DoSomething); //(new Thread start 어떻게 넣는건지
            t1.Start();

            for (int i = 0; i < 1000; i++)
            {
                if (i == 100)
                    t1.Abort();
            }
            t1.Join();
            t1.Abort();
        }
    }
}
