using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_107p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, Tab;
            textBox1.Text = " ";

            for(i = 1; i <= 9; i+=3)
            {
                for(j = 1; j <= 9; j++)
                {
                    for(Tab = 0; Tab <= 2; Tab++)
                    {
                        textBox1.Text = textBox1.Text + (i + Tab) + " X " + j + " = ";
                        textBox1.Text = textBox1.Text + ((i + Tab) * j) + "         ";

                    }
                    textBox1.Text = textBox1.Text + Environment.NewLine;
                }
                textBox1.Text = textBox1.Text + Environment.NewLine;
            }
        }
    }
}
