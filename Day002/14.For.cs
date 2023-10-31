using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i = 0;
            for(i=0; i<3; i++)
            {
                Console.WriteLine("냠");
            }
            */

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i+1);
            }
            //Console.WriteLine(i); // for문 안에서 i를 선언했기 때문에 for문 외부에서 사용 불가능
        }
    }
}
