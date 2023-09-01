using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteQuiz001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;
            a = Int32.Parse(Console.ReadLine());
            b = 9.0 / 5 * a + 32;

            Console.WriteLine(b);

            /*int width, height;
            double area;

            width = int.Parse(Console.ReadLine());
            height = int.Parse(Console.ReadLine());

            area = (double)(width * height) / 2.0; // 2.0; = (double)2;

            Console.WriteLine(area);
            */
        }
    }
}

/*프로그램 명: CtoF

섭씨 온도를 화씨 온도로 변환하는 프로그램을 작성하세요.

화씨 온도 = 9 / 5 * 섭씨온도 + 32

입력
1 에서 100 사이의 자연수가 입력으로 주어진다.

출력
소수 첫째 자리까지 출력한다.
*/