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
            Console.WriteLine("ABC".ToLower()); // 문자를 소문자로 변환해 출력
            Console.WriteLine("abc".ToUpper()); // 문자를 대문자로 변환해 출력
            Console.WriteLine();

            Console.WriteLine("Happy Friday!".Insert(5, " Sunny")); // 5번 인덱스에 "Sunny" 문자열 삽입 후 출력
            Console.WriteLine("I Don't Love You".Remove(2, 6)); // 2번 인덱스부터 6개의 문자열 삭제 후 출력
            Console.WriteLine();

            Console.WriteLine("     ABC     ");
            Console.WriteLine("     ABC     ".Trim()); // 문자 양 옆의 공백 제거 후 출력
            Console.WriteLine("     A B C     ".Trim()); // 출력 결과 => A B C
        }
    }
}
