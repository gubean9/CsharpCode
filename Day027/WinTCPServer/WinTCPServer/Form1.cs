using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //아래 둘 다 프로그램을 종료시키는 코드
            Dispose();
            //Environment.Exit(0);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            int port = 13000;
            TcpListener server = new TcpListener(localAddr, port);
            server.Start();
            richTextBox1.AppendText("연결을 기다리는 중...");

            while (true)
            {
                //클라이언트 연결 수락
                TcpClient client = await server.AcceptTcpClientAsync();

                //이름 명시 없이 Tast.Run()으로 사용 가능
                Task task = Task.Run(() => HandleClient(client));
            }


        }

        private async void HandleClient(TcpClient client)
        {
            //Console.WriteLine("연결 성공");
            //richTextBox1.AppendText("연결 성공");
            AppendText("연결 성공\n");

            //네트워크 전송
            using(NetworkStream stream = client.GetStream())
            {
                byte[] data = new byte[256];
                int bytes;

                while((bytes = await stream.ReadAsync(data, 0, data.Length)) > 0)
                {
                    AppendText(Encoding.UTF8.GetString(data, 0, bytes) + "\n");
                }
            }
            client.Close();
        }

        private void AppendText(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action<string>(AppendText), text);
            }
            else
            {
                richTextBox1.AppendText(text);
            }
        }
    }
}
