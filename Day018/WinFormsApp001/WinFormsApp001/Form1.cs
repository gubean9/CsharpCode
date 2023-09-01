using System.Diagnostics;

namespace WinFormsApp001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. 메시지 박스 사용
            MessageBox.Show("안녕하세요. 윈도우 프로그램입니다.");
            //2. 디버그 로그에 출력
            Trace.WriteLine(string.Format($"{System.DateTime.Now}: 출력메세지"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#의 세상에 오신 것을 환영합니다.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "절대 누르지 말라고 했는데";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //this는 생략 가능
        }
    }
}