using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTCPFileClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPAddress serverAddr = IPAddress.Parse("127.0.0.1");
            int port = 13001;


            //클라이언트 소켓 생성
            TcpClient client = new TcpClient();
            client.Connect(serverAddr, port); //Accept
            Console.WriteLine("서버에 연결되었습니다.");

            //주고받기 => 사진받기
            string filePath = @".\\newjeans.png";
            using(NetworkStream stream = client.GetStream())
            {
                byte[] data = new byte[1024];
                using(FileStream ts = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    int bytesRead;

                    while((bytesRead = stream.Read(data, 0, data.Length)) > 0)
                    {
                        ts.Write(data, 0, bytesRead);
                    }
                }
            }

            Console.WriteLine($"파일 수신 완료 : {filePath}");
            client.Close();

        }
    }
}
