using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvent
{
    internal class MainApp : Form
    {
        public void MyMouseHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"Sender : {((Form)sender).Text}");
            Console.WriteLine($"X : {e.X}, Y : {e.Y}");
            Console.WriteLine($"Button : {e.Button} Clicks : {e.Clicks}");
            Console.WriteLine();
        }
        public MainApp(string title)
        {
            this.Text = title;
            this.MouseDown += new MouseEventHandler(MyMouseHandler);
        }
        static void Main(string[] args)
        {
            //이렇게도 가능하고
            //Application.Run(new MainApp("마우스 이벤트 테스트"));

            //이렇게도 가능함
            MainApp app = new MainApp("마우스 이벤트 테스트");
            Application.Run(app);
        }
    }
}
