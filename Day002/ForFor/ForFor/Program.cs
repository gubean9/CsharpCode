using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int cnt = 0;
            for(int i=0; i<25; i++)
            {
                cnt++;
            }
            Console.WriteLine(cnt);
            */

            int cnt = 0;
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
