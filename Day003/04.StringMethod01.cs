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

            // IndexOf() 문자가 처음 나타나는 인덱스 출력
            Console.WriteLine($"IndexOf : {greeting.IndexOf("Good")}");
            Console.WriteLine($"IndexOf : {greeting.IndexOf("o")}");

            Console.WriteLine($"IndexOf : {greeting.IndexOf("Morning")}");
            Console.WriteLine($"IndexOf :  {greeting.IndexOf("d")}");
            Console.WriteLine();

            // LsatIndexOf() 문자가 마지막으로 나타나는 인덱스 출력
            Console.WriteLine($"LastIndex : {greeting.LastIndexOf("Good")}");
            Console.WriteLine($"Last Index : {greeting.LastIndexOf("o")}");
            Console.WriteLine();

            // StartWith() 주어진 문자로 시작하는지 True/False로 출력
            Console.WriteLine($"StartWith : {greeting.StartsWith("Good")}");
            Console.WriteLine($"StartWith : {greeting.StartsWith("Morning")}");
            Console.WriteLine();

            // EndsWith() 주어진 문자로 끝나는지 True/False로 출력
            Console.WriteLine($"EndsWith : {greeting.EndsWith("Good")}");
            Console.WriteLine($"EndsWith : {greeting.EndsWith("Morning")}");
            Console.WriteLine();

            // Contains() 주어진 문자가 포함되어 있는지 True/False로 출력
            Console.WriteLine($"Contains Evening : {greeting.Contains("Evening")}");
            Console.WriteLine($"Contains Morning : {greeting.Contains("Morning")}");
            Console.WriteLine();

            // Replace() 특정 문자열을 다른 문자열로 대체한 결과를 출력
            Console.WriteLine($"Replace Evening : {greeting.Replace("Morning", "Evening")}");
            Console.WriteLine();
        }
    }
}
