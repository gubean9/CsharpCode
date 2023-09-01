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
            string path = "abc.txt";
            StreamReader sr = new StreamReader(path);
            string txt = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine(txt);

            
        }
    }
}
