using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mat src = Cv2.ImRead("C:\\Temp\\img\\image.jpg");
            Mat gray = new Mat(); // 비어있는 화면
            Mat hist = new Mat();
            Mat result = Mat.Ones(new Size(256, src.Height), MatType.CV_8UC1);
            Mat dst = new Mat();

            // 컬러 => 흑백
            Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);
            // 히스토그램 그리기
            Cv2.CalcHist(new Mat[] { gray },
                         new int[] { 0 },
                         null,
                         hist,
                         1,
                         new int[] { 256 },
                         new Rangef[] { new Rangef(0, 256) });

            // 평탄화
            Cv2.Normalize(hist, hist, 0, 255, NormTypes.MinMax);

            for (int i = 0; i < hist.Rows; i++)
            {
                Cv2.Line(result,
                         new Point(i, src.Height),
                         new Point(i, src.Height - hist.Get<float>(i)),
                         Scalar.White);
            }

            Cv2.ImShow("제목", src); // 제목을 꼭 적어야 함
            Cv2.ImShow("dst", gray);
            Cv2.ImShow("hist", hist);

            Cv2.HConcat(new Mat[] { gray, result }, dst);
            Cv2.ImShow("dst2", dst);

            Cv2.WaitKey(); // ()안에 아무것도 없거나 0으로 해두면 무한이다
        }
    }
}
