using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //임베디드 프로그래밍 50%는 I/O 입출력
            //리눅스는 모든것이 File => low level => byte[]

            //File과 FileInfo
            //FileStream fs = File.Create("C:\\Temp\\a.dat"); //경로 설정
            //FileStream fs = File.Create("a.dat");

            //File.Copy("a.dat", "d.dat");

            try
            {

                FileInfo file = new FileInfo("b.dat");
                FileStream fs = file.Create(); //생성
                fs.Close();
                FileInfo src = new FileInfo("b.dat");
                FileInfo dst = src.CopyTo("e.dat"); //복사

                File.Delete("b.dat");
                FileInfo deleteFile = new FileInfo("e.dat");
                deleteFile.Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
