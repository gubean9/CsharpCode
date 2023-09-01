using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _472p_예제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for(int i = 0; i < 10;  i++)
            {
                arr[i] = i;
            }

            try
            {
                for (int i = 0; i < 11; i++)
                    Console.WriteLine(arr[i]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            finally
            {
                Console.WriteLine("프로그램이 종료되었습니다");
            }
        }
    }
}
