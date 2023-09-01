using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer01
{
    internal class Program
    {
        //배열은 상수형이라 100개의 공간을 만들면 100개의 메모리 공간을 잡고 시작함
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };
            ArrayList list1 = new ArrayList(arr);

            ArrayList list2 = new ArrayList();
            list2.Add(1);
            list2.Add(2);

            foreach(int i in list2)
                Console.WriteLine(i);
        }
    }
}
