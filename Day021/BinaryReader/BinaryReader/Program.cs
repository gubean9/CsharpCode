using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BinaryReader_
{
    internal class Program
    {
        static void Run(string path, byte[] )
        static void Main(string[] args)
        {
            string path = "pic1.png";
            byte[] picture;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryReader br = new BinaryReader(fs);
                picture = br.ReadBytes((int)fs.Length);
                br.Close();
            }


            path = "pic2.png";

            Thread t1 = new Thread(() => Run(path, picture));
            t1.Name = "Thread1";
            t1.Start();
            t1.IsBackground = true;
            t1.Join();

            Thread t1 = new BinaryWriter(fs);
            
            //using(FileStream fs = new FileStream(path, FileMode.Create))
            //{
            //    BinaryWriter bw = new BinaryWriter(fs);
            //    bw.Write(picture);
            //    bw.Flush();
            //    bw.Close();
            //}
        }
    }
}
