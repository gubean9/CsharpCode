using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormStyle04
{
    internal class MainApp : Form
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.Text = "버튼 : 눌러주세요";
            button.Left = 100;
            button.Top = 50;

            button.Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("딸깍");
            };

            MainApp form = new MainApp();
            form.Controls.Add(button);
            //form.
            Application.Run(form);
        }
    }
}
