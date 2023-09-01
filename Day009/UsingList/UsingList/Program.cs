using System;
using System.Collections;

namespace UsingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int cnt = 10;

            for (int i = 0; i < 5; i++)
            {
                //1. 요소 추가
                list.Add(cnt);
                cnt += 10;
            }

            foreach (int n in list)
                Console.Write(n + " ");

            Console.WriteLine();

            //2. 요소 삭제
            //list.Remove(list[2]);
            list.RemoveAt(2);

            foreach (int n in list)
                Console.Write(n + " ");

            Console.WriteLine();

            //3. 요소 삽입
            list.Insert(2, 5);

            foreach (int n in list)
                Console.Write(n + " ");

            Console.WriteLine();


        }
    }
}
