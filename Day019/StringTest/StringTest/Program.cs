using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stream stream1 = new FileStream("a.dat", FileMode.Create);
            //Stream stream2 = new FileStream("b.dat", FileMode.Open);
            //Stream stream3 = new FileStream("c.dat", FileMode.OpenOrCreate);

            Stream outStream = new FileStream("f.dat", FileMode.Create);


            long someValue = 0x123456789ABCDEF0;

            byte[] wBytes = BitConverter.GetBytes(someValue);

            outStream.Write(wBytes, 0, wBytes.Length);

            outStream.Close();
        }
    }
}
