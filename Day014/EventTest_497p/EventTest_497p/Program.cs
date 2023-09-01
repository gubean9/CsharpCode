using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest_497p
{
    delegate void EventHandler(string message);
    //EventHandler를 이름으로 많이 쓴다고? 함?

    class MyNotifier
    {
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10; //10개씩 끊기 %가 들어가면 그 단위만큼 끊어간다고 생각하기

            if (temp != 0 && temp % 3 == 0)
                SomethingHappened(string.Format($"{number} : 짝"));
        }
    }


    internal class Program
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            MyNotifier ntf = new MyNotifier();
            ntf.SomethingHappened += new EventHandler(MyHandler);

            for(int i = 1; i < 30; i++)
            {
                ntf.DoSomething(i);
            }
        }
    }
}