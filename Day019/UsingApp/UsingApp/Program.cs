using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.파일 스트림 생성
            using (Stream outStream = new FileStream("g.dat", FileMode.Create));
            {
                //2.someValue(long 형식)을 byte 배열로 변환


                //3.변환할 byte 배열을 파일 스트림을 통해 파일에 기록

            }
        }
    }
}
