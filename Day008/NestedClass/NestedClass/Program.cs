using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClass
{
    //클래스 중첩이 가능하다~!
    //외부(OuterClass), 내부(InnerClass) 클래스
    class OuterClass //외부클래스
    {
        private int OuterNumber;
        class InnerClass //내부클래스
        {
            public void DoSomething()
            {
                OuterClass outer = new OuterClass();
                outer.OuterNumber = 100;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
