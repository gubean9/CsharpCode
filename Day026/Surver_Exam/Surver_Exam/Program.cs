using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            int port = 13000;

            TcpListener server = new TcpListener(localAddr, port);
            server.Start();
            Console.WriteLine("서버 시작...");

            using (TcpClient client = server.AcceptTcpClient())
            {
                Console.WriteLine("연결 성공");

                using (NetworkStream stream = client.GetStream())
                {
                    string response = "안녕하세요 클라이언트";
                    byte[] data = Encoding.UTF8.GetBytes(response);

                    stream.Write(data, 0, data.Length);
                    Console.WriteLine($"전송한 메시지 : {response}");
                }
            }

            server.Stop();
        }
    }
}
