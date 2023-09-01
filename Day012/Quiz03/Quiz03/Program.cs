using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz03
{
    internal class Program
    {
        public int Count(char[] arr, char ch)
        {
            int N = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ch)
                {
                    N++;
                }
            }
            return N;
        }

        static void Main(string[] args)
        {
            Console.Write("문자열 : ");
            string st = Console.ReadLine();
            Console.Write("문자 : ");
            string st2 = Console.ReadLine();

            //char c = st2[0];
            char c = st2.ElementAt(0);
            //C#은 이걸 더 많이 씀 가장 메소드스러움
            //근데 비추 타 언어로 전향이 쉽도록 짜는 것이 좋다~

            Program count = new Program();

            int result = count.Count(st.ToCharArray(), c);

            Console.WriteLine($"결과 : {result}");
            
        }
    }
}
