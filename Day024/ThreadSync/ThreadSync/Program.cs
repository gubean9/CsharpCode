using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSync
{
    class Counter
    {
        public int count = 0;
        private readonly object thisLock = new object();
        public void Increase()
        {
            lock(thisLock)
            {
                count++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Thread[] t = new Thread[10000];

            for (int i = 0; i < 10000; i++)
            {
                t[i] = new Thread(counter.Increase);
                t[i].Start();
                t[i].Join();
            }

            //Thread t1 = new Thread(counter.Increase);
            //Thread t2 = new Thread(counter.Increase);
            //Thread t3 = new Thread(counter.Increase);

            //t1.Start();

            //t1.Join();

            Console.WriteLine(counter.count);
        }
    }
}
