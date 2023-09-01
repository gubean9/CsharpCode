using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method01
{
    internal class Program
    {
        static void Method01()
        {
            Console.WriteLine("Method01");
        }

        static int Method02()
        {
            Console.WriteLine("Method02");
            return 100; //return타입은 return값과 관련있음?ㅁㅁ??
        }

        static string Method03()
        {
            Console.WriteLine("Method03");
            return "안녕하세요";
        }

        static int Method04(int n)
        {
            return n;
        }

        static double Method05(int a, int b)
        {
            double result = a + b; //묵시적 형변환
            return result;
        }

        static void Main(string[] args)
        {
            Method01(); //int a = Method01(); 컴파일 오류
            int a = Method02(); //int b = Method02(); 가능
            string b = Method03(); //얘네 왜 출력되지......?
            Console.WriteLine(a);
            Console.WriteLine(b);
            int n = Method04(999); //매개변수/파라미터/인자값 => 변수가 두 개 생김
            Console.WriteLine(n);

            double d = Method05(100, 200);
            Console.WriteLine(d);
        }
    }
}
