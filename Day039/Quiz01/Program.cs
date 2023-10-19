using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mat src = new Mat();


            using (Mat image = new Mat(200, 300, MatType.CV_8U, new Scalar(255)))
            {
                Cv2.NamedWindow("키보드 이벤트", WindowFlags.AutoSize);
                Cv2.ImShow("키보드 이벤트", image);

                while (true)
                {
                    int key = Cv2.WaitKeyEx(200);

                    if (key == 27) // 'ESC' key
                        break;

                    switch (key)
                    {                        
                        case (int)MouseEventFlags.LButton: // 왼쪽 마우스
                            Console.WriteLine("왼쪽 마우스 입력");
                            break;
                        case 2621440: // 아래쪽 화살표
                            Console.WriteLine("아래쪽 화살표 키 입력");
                            break;
                            //default:
                            //    Console.WriteLine(key);
                            //    break;
                    }
                }
            }
        }

        //static void Event(MouseEventTypes @event, int x, int y, MouseEventFlags flags, IntPtr userdata)
        //{
        //    Mat data = new Mat(userdata);

        //    if(flags == MouseEventFlags.LButton)
        //    {
        //        Cv2.Circle(data, new Point(x, y), 10, new Scalar(0, 0, 255), -1);
        //        Console.WriteLine("왼쪽 마우스 누르기");
        //    }
        //}
    }
}
