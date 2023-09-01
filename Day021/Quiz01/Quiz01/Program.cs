using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "a.txt";
            using (FileStream fs = File.Create(path))
            {

            }
        }
    }
}
