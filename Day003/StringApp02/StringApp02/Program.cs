using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABC".ToLower());
            Console.WriteLine("abc".ToUpper());
            Console.WriteLine();

            Console.WriteLine("Happy Friday!".Insert(5, " Sunny"));
            Console.WriteLine("I Don't Love You".Remove(2, 6));
            Console.WriteLine();

            Console.WriteLine("     ABC     ");
            Console.WriteLine("     ABC     ".Trim());
        }
    }
}
