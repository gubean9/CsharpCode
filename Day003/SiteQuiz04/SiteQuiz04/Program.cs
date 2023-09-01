using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteQuiz04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            //메모리에 입력
            for(int i = 0, cnt = 1; i < arr.Length; i++, cnt+=2)
            {
                arr[i] = cnt;
            }

            //화면(콘솔)에 출력
            for(int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }
    }
}
