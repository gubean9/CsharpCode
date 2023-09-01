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

namespace Quiz01
{
    public partial class Form1 : Form
    {
        /*
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            label1.Text = date.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
        */

        private DateTime NowTime;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Action time = () => {
                while (true)
                {
                    label1.Text = DateTime.Now.ToString("mm:ss");
                    Thread.Sleep(1000);
                }
            };
            Thread t1 = new Thread(new ThreadStart(time));
            t1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
