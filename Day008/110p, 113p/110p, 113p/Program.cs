using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _110p__113p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //p.110 예제
            //DateTime dt = new DateTime(1998, 10, 14, 16, 18, 00);
            DateTime dt = DateTime.Now;

            Console.WriteLine("12시간 형식 : {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            Console.WriteLine($"12시간 형식 : {dt:yyyy-MM-dd tt hh:mm:ss (ddd)}");

            Console.WriteLine("24시간 형식 : {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            CultureInfo ciKo = new CultureInfo("ko-KR");
            Console.WriteLine();
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt HH:mm:ss (dddd)", ciKo));
            Console.WriteLine(dt.ToString(ciKo));
            */

            //p.113 예제
            string name = "대협";
            int age = 24;
            int month = 0;
            /*
            Console.WriteLine($"{name, -10}, {age:D3}");

            name = "대감";
            age = 30;
            Console.WriteLine($"{name}, {age,-10:D3}");

            name = "아기만두";
            age = 4;
            Console.WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");

            name = "어른만두";
            age = 28;
            Console.WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");
            */

            name = "2정파";
            month = 2;
            Console.WriteLine($"{name}, {(month < 6 ? "아기만두" : "고대만두")}");

            name = "12정파";
            month = 12;
            Console.WriteLine($"{name}, {(month < 6 ? "아기만두" : "고대만두")}");
        }
    }
}
