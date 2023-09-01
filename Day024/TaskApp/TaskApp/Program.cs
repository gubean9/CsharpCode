using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //main 동작중
            Action someAction = () =>
            {
                //1. 1~100까지 더하기
                //2. A~Z까지 출력
                Console.WriteLine("someAction1");
            };

            Task myTask1 = new Task(someAction); //Action 대리자 구현부
            myTask1.Start();
            myTask1.Wait(); //Join()


            Task myTask2 = new Task.Run(() =>
            {
                Console.WriteLine("someAction2~!");
            });
            //myTask2.Start();
            myTask2.Wait();

            Console.WriteLine("main 종료");
        }
    }
}
