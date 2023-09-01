using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz01
{
    internal class MainApp : Form
    {
        static void Clicked(object sender, MouseEventArgs e)
        {
            Console.WriteLine("X : " + e.X);
            Console.WriteLine("Y : " + e.Y);

            if (e.Button == MouseButtons.Left)
                Console.WriteLine("왼쪽 마우스 버튼을 클릭하셨습니다.");
            else if (e.Button == MouseButtons.Right)
                Console.WriteLine("오른쪽 마우스 버튼을 클릭하셨습니다.");
            else
                Console.WriteLine("가운데 마우스 버튼을 클릭하셨습니다.");

        }

        static void Main(string[] args)
        {
            MainApp form = new MainApp();
            form.MouseClick += Clicked;
            Application.Run(form);
        }
    }
}
