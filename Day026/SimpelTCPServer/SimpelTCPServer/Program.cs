using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpelTCPServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 인터넷 주소 만들기, 서버주소 만들기, 포트 만들기
            IPAddress localAddr = IPAddress.Parse("192.168.39.231");
            int port = 13000;

            //2. 서버 객체 만들기
            TcpListener server = new TcpListener(localAddr, port);
            server.Start();
            Console.WriteLine("서버 시작...");

            using(TcpClient client = server.AcceptTcpClient()) //Block I/O
            {
                Console.WriteLine("연결성공");

                //클라이언트에 메세지 보내고싶음
                //3. 소켓에 write 할 준비
                using (NetworkStream stream = client.GetStream()) //write 대상 객체 생성 클라이언트가 겟
                {
                    string response = "안녕하세요 클라이언트";
                    byte[] data = Encoding.UTF8.GetBytes(response);

                    //데이터 전송(write)
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine($"전송한 메시지 : {response}");
                }
                
            }

            server.Stop();
        }
    }
}
