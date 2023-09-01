using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using static System.Console; Console 하나하나 안 써도 됨

namespace StringApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            
            Console.WriteLine(greeting);
            Console.WriteLine();

            //IndexOf()
            Console.WriteLine($"IndexOf : {greeting.IndexOf("Good")}");
            Console.WriteLine($"IndexOf : {greeting.IndexOf("o")}");

            Console.WriteLine($"IndexOf : {greeting.IndexOf("Morning")}");
            Console.WriteLine($"IndexOf :  {greeting.IndexOf("d")}");
            Console.WriteLine();

            //LsatIndexOf()
            Console.WriteLine($"LastIndex : {greeting.LastIndexOf("Good")}");
            Console.WriteLine($"Last Index : {greeting.LastIndexOf("o")}");
            Console.WriteLine();

            //StartWith()
            Console.WriteLine($"StartWith : {greeting.StartsWith("Good")}");
            Console.WriteLine($"StartWith : {greeting.StartsWith("Morning")}");
            Console.WriteLine();

            //EndsWith()
            Console.WriteLine($"EndsWith : {greeting.EndsWith("Good")}");
            Console.WriteLine($"EndsWith : {greeting.EndsWith("Morning")}");
            Console.WriteLine();

            //Contains()
            Console.WriteLine($"Contains Evening : {greeting.Contains("Evening")}");
            Console.WriteLine($"Contains Morning : {greeting.Contains("Morning")}");
            Console.WriteLine();

            //Replace()
            Console.WriteLine($"Replace Evening : {greeting.Replace("Morning", "Evening")}");
            Console.WriteLine();
        }
    }
}
