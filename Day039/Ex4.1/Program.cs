using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mat src = Cv2.ImRead("C:\\Temp\\img\\OpenCV_Logo.png", ImreadModes.ReducedColor2);

            Cv2.NamedWindow("src", WindowFlags.GuiExpanded);
            Cv2.SetWindowProperty("src", WindowPropertyFlags.Fullscreen, 0);
            Cv2.ImShow("First", src);
            Cv2.WaitKey();
            Cv2.DestroyWindow("src");

            Console.WriteLine(src);

            Cv2.ImShow("Second", src);
            Cv2.WaitKey();
        }
    }
}
