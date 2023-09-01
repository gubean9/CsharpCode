using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//437p 예제
namespace Egneric04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for(int i = 0; i < 5; i++)
                list.Add(i);
            
            foreach(int element in list) //객체지향에 많이 사용하는 변수 element or item
                Console.Write(element);
            Console.WriteLine();

            //list.Remove(4); //값을 제거하려면 Remove
            list.RemoveAt(2); //인덱스를 제거하려면 RemoveAt

            foreach (int element in list)
                Console.Write(element);
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (int element in list)
                Console.Write(element);
            Console.WriteLine();
        }
    }
}
