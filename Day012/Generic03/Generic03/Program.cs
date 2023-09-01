using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic03
{
    class MyList<T> where T : struct //T는 값 형식이어야 함
    {

    }
    class Car<T> where T : class //T는 참조 형식이어야 함
    {

    }
    class Dog<T> where T : new() //T는 반드시 매개 변수가 없는 생성자가 있어야 함
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
