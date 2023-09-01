using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str;
            str = "당신의 연령은 " + "\n";
            if (radioButton1.Checked == true) str = str + radioButton1.Text;

            str = str + "\n" + "\n" + "좋아하는 색은" + "\n";
            if(checkBox1.Checked == true) str = str + checkBox1.Text + "\n";

            str = str + "입니다";
            label1.Text = str;
        }
    }
}
