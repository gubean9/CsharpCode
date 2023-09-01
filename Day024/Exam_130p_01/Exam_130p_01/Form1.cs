using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_130p_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iJumsu;
            String sHakjum;
            if(textBox1.Text == "")
            {
                MessageBox.Show("점수를 입력하세요", "경고 1");
                goto Nagayo;
            }
            iJumsu = int.Parse(textBox1.Text);
            if(iJumsu > 100 || iJumsu < 0)
            {
                MessageBox.Show("0~100 사이의 점수를 입력하세요", "경고 2");
                goto Nagayo;
            }
            if (iJumsu >= 96)
                sHakjum = "A+";
            else if (iJumsu >= 91)
                sHakjum = "A0";
            else if (iJumsu >= 86)
                sHakjum = "B+";
            else if (iJumsu >= 81)
                sHakjum = "B0";
            else if (iJumsu >= 76)
                sHakjum = "C+";
            else if (iJumsu >= 71)
                sHakjum = "C0";
            else if (iJumsu >= 66)
                sHakjum = "D+";
            else if (iJumsu >= 61)
                sHakjum = "D0";
            else
                sHakjum = "F : 재수강";
            textBox2.Text = sHakjum;
        Nagayo: textBox1.Focus();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.TextLength;
        }
    }
}
