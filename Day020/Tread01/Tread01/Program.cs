using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tread01
{
    internal class Program
    {
        static void DoSomething()
        {
            for(int i = 1; i < 1000; i++)
            {
                ;
            }
            Console.WriteLine($"DoSomething Tread ID : {Thread.CurrentThread.ManagedThreadId}");
        }
        static void Print()
        {
            Console.WriteLine($"Print Tread ID : {Thread.CurrentThread.ManagedThreadId}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Tread ID : {Thread.CurrentThread.ManagedThreadId}");
            Print();
            Thread t = new Thread(new ThreadStart(DoSomething));
            t.Start();
        }
    }
}
