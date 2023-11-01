using System;

namespace SwitchCase01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            double num = 1.1;

            switch (num)
            {
                case 1.1:
                    Console.WriteLine("1.1이 출력되었습니다");
                    break;
                case 2.1:
                    Console.WriteLine("2.1 출력되었습니다");
                    break;
                default:
                    Console.WriteLine("기본값이 출력되었습니다");
                    break;
            }
            */
            Console.Write("숫자를 입력해주세요 :");
            int num = Int32.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("월요일입니다.");
                    break;
                case 2:
                    Console.WriteLine("화요일입니다.");
                    break;
                case 3:
                    Console.WriteLine("수요일입니다.");
                    break;
                case 4:
                    Console.WriteLine("목요일입니다.");
                    break;
                case 5:
                    Console.WriteLine("금요일입니다.");
                    break;
                case 6:
                    Console.WriteLine("토요일입니다.");
                    break;
                case 7:
                    Console.WriteLine("일요일입니다.");
                    break;

                default:
                    Console.WriteLine("기본값이 출력되었습니다");
                    break;
            }
        }
    }
}
