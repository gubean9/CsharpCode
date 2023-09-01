using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            int sum1 = 0;
            int sum2 = 0;
            int N = int.Parse(textBox1.Text);

            for(int i = 1; i <= N; i += 2)
            {
                sum1 = sum1 + i;
            }

            for(int i = 0; i <= N; i += 2)
            {
                sum2 = sum2 + i;
            }

            textBox2.Text = sum1.ToString();
            textBox3.Text = sum2.ToString();

        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            int sum1 = 0;
            int sum2 = 0;
            int N = int.Parse(textBox1.Text);

            for (int i = 1; i <= N; i += 2)
            {
                sum1 = sum1 + i;
                textBox2.Text = textBox2.Text + i + " + ";
            }

            for (int i = 2; i <= N; i += 2)
            {
                sum2 = sum2 + i;
                textBox3.Text = textBox3.Text + i + " + ";
            }

            textBox2.Text = textBox2.Text.TrimEnd('+', ' ') + " = " + sum1.ToString();
            textBox3.Text = textBox3.Text.TrimEnd('+', ' ') + " = " + sum2.ToString();

        }
    }
}
