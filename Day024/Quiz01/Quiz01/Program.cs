using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action someAction = () =>
            {
                int sum = 0;
                for (int i = 1; i <= 100; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine(sum);
            };

            Action Out = () =>
            {
                for (char a = 'A'; a <= 'Z'; a++)
                    Console.Write(a + " ");
            };

            Task mytask1 = new Task(someAction);
            mytask1.Start();
            mytask1.Wait();

            Task mytask2 = new Task(Out);
            mytask2.Start();
            mytask2.Wait();
        }
    }
}
