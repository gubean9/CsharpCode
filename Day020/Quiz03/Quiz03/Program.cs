using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quiz03
{
    internal class Program
    {
        static void Plus()
        {
            int result = 0;
            for(int i = 0; i <= 100; i++)
            {
                result += i;
            }
            Console.WriteLine(result);
        }

        static void Out()
        {

            for(int i = 0; i <= 26; i++)
            {
                Console.Write()
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(Plus));
            t.Name = "Plus";
            t.Start();
            t.Join();

            Thread mk2 = new Thread(new ThreadStart(Out));
        }
    }
}
