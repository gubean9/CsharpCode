using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//492p 아마?
namespace Annonymous01
{
    //delegate int Calculate(int a, int b);
    //안/밖어디 들어가도 상관없음
    internal class Program
    {
        delegate int Calculate(int a, int b);

        static void Main(string[] args)
        {
            Calculate Calc;

            Calc = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(Calc(3, 4));
        }
    }
}
