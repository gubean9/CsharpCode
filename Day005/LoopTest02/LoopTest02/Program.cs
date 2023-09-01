using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTest02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 0;
            int cnt = 3;

            while(i < 5)
            {
                Console.WriteLine(cnt += 3);
                i++;
            }
            */

            int i = 0;

            while(i < 5)
            {
                Console.WriteLine(i++); //전치연산자 ++i, 후치연산자 i++ => 더하고 돌리기 돌리고 더하기
                Console.WriteLine("i : " + i); //전치 후치 같은 값 출력됨
                //한줄에 변수 동시에 사용하지 않음 !!컴파일러마다 값이 달라짐!!
                //1줄 아래는 무조건 +1?
            }
        }
    }
}
