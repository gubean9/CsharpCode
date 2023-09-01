using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_88p
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
            int sum = 0;
            int N = int.Parse(textBox1.Text);
            for(int i = 0; i <= N; i++)
            {
                sum = sum + i;
            }
            textBox2.Text = sum.ToString();
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int N = int.Parse(textBox1.Text);
            for (int i = 0; i <= N; i++)
            {
                sum = sum + i;
                textBox2.Text = textBox2.Text + i + " + ";
            }
            textBox2.Text = textBox2.Text.TrimEnd('+', ' ') + " = " + sum;
        }
    }
}
