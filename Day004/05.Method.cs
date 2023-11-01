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
            return 100; // return타입은 return값과 관련이 있다
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
            double result = a + b; // 묵시적 형변환
            return result;
        }

        static void Main(string[] args)
        {
            Method01(); // int a = Method01(); 로 입력하면 컴파일 오류
            // Method01의 반환 유형이 void이기 때문에 int 변수에 직접 할당할 수 없음
            int a = Method02(); // int b = Method02(); 가 가능함
            string b = Method03(); // Method03을 호출해 실행함
            Console.WriteLine(a);
            Console.WriteLine(b);
            int n = Method04(999); // 매개변수/파라미터/인자값 => 999를 인자로 전달해 Method04를 호출하고 Method04는 입력받은 인자를 출력
            // 이 코드의 n과 Method04안의 n은 서로 다른 변수
            Console.WriteLine(n);

            double d = Method05(100, 200);
            Console.WriteLine(d);
        }
    }
}
