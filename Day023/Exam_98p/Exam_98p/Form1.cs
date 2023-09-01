using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_98p
{
    public partial class Form1 : Form
    {
        private int Number = 0; //책에는 private 안 붙어있는데 붙이는 것이 좋다
        private DateTime NowTime;

        public Form1()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 1; i <= 5; i++)
            {
                GetNumber();
                OutNumber();
                GetTime();
                OutTime();
                System.Threading.Thread.Sleep(1000);
            }
            */


            //http://www.verthasys.co.kr/coding//bbs/board.php?bo_table=csharp&wr_id=79 해당 코드로 수정 요
            await Task.Run(() =>
            {
                for (int i = 0; i <= 5; i++)
                {
                    GetNumber();
                    this.Invoke(new Action(() =>
                    {
                        OutNumber();
                    }));
                    GetTime();
                    this.Invoke(new Action(() =>
                    {
                        OutTime();
                    }));
                    Thread.Sleep(1000);
                }
            });
        }

        //사용자 정의 함수
        public void GetNumber()
        {
            Number++;
        }
        public void OutNumber()
        {
            textBox1.AppendText(Number + "\r\n");
        }
        public void GetTime()
        {
            NowTime = DateTime.Now;
        }
        public void OutTime()
        {
            textBox2.AppendText(NowTime + "\r\n");
        }

        
    }
}
