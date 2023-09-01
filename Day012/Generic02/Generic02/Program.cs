using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic02
{
    class MyList<T>
    {
        private T[] array;
        public MyList()
        {
            array = new T[3];
        }
        public T this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }
    }
    internal class Program
    {
        //단수로 넣는 것과 배열로 사용하는 것은 다름 주의하기
        static void CopyArray<T>(T a, T b) //T[]로 쓰면 배열형으로 사용 가능
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
