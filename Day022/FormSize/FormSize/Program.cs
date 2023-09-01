﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSize
{
    internal class MainApp : Form
    {
        static void form_MouseDown(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("마우스가 클릭되었습니다");
            Form form = (Form)sender; //Down Casting
            int oldWidth = form.Width;
            int oldHeight = form.Height;

            if (e.Button == MouseButtons.Right)
            {
                if(oldHeight < oldWidth)
                {
                    form.Width = oldHeight;
                    form.Height = oldWidth;
                }
                Console.WriteLine("오른쪽 마우스 버튼이 클릭되었습니다");
            }
            else if(e.Button == MouseButtons.Left)
            {
                if (oldHeight > oldWidth)
                {
                    form.Width = oldHeight;
                    form.Height = oldWidth;
                }
                Console.WriteLine("왼쪽 마우스 버튼이 클릭되었습니다");
            }
        }
        static void Main(string[] args)
        {
            MainApp form = new MainApp();
            form.Width = 600;
            form.Height = 400;

            //마우스 이벤트 처리
            //1. 왼쪽 버튼 눌렀을 때
            form.MouseClick += form_MouseDown;
            //2. 오른쪽 버튼 눌렀을 때



            Application.Run(form);
        }
    }
}
