using System;

namespace SIteQuiz03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("단을 입력하세요 : ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 2:
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 1; j++)
                            Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;

                case 3:
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 1; j++)
                            Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;

                case 4:
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 1; j++)
                            Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;

                case 5:
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 1; j++)
                            Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;

                case 6:
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 1; j++)
                            Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;

                case 7:
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 1; j++)
                            Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;

                case 8:
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 1; j++)
                            Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;

                case 9:
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 1; j++)
                            Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;
            }
        }
    }
}


//이중for 없이 출력하는 버전
using System;

namespace SIteQuiz03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("단을 입력하세요 : ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 2:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine($"{num} X {i} = {num * i}");                            
                    }
                    break;

                case 3:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;

                case 4:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;

                case 5:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;

                case 6:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;

                case 7:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;

                case 8:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;

                case 9:
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    break;
                default:
                    Console.WriteLine("입력값이 잘못되었습니다.");
                    break;
            }
        }
    }
}
