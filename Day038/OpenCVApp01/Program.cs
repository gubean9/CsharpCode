using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace OpenCVApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var src = new Mat("lenna.jpg", ImreadModes.Grayscale);
            var src2 = new Mat("lenna.jpg", ImreadModes.Color);
            var dst = new Mat();

            Cv2.Canny(src, dst, 50, 200);
            new Window("src image", src); // opencv 윈도우 라이브러리 창 만들기
            new Window("dst image", dst); // 원본을 가지고 가공한 목적파일
                                          // ("제목", 변수) 제목을 안 쓰면 안돌아감
            new Window("src2 image", src2);
            Cv2.WaitKey();

        }
    }
}
