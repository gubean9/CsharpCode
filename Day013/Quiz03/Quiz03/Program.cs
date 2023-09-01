using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Quiz03
{
    internal class Program
    {
        public void Method(int size)
        {
            int[] arr = new int[5] {1, 2, 3, 4, 5};


            if (size < 6)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("정상종료");
            }
            else
            {
                Console.WriteLine("예외발생");
                throw new Exception("안전종료");
            }
            
            /*
            if (size < 6)
                Console.WriteLine("정상종료");
            else
            {
                Console.WriteLine("예외발생");
                throw new Exception("안전종료");
            }
            */
        }
        static void Main(string[] args)
        {
            /*
            Program pr = new Program();
            pr.Method(2);
            */

            Program pr = new Program();
            Console.Write("입력 : ");
            int size = int.Parse(Console.ReadLine());

            try
            {
                pr.Method(size);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
