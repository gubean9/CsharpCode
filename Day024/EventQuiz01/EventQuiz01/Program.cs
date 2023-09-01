using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventQuiz01
{
    public delegate void DataReceivedEventHandler(object sender, EventArgs e);

    public class DataReceiver
    {
        public event DataReceivedEventHandler DataReceived;
        //DataReceivedEventHandler 타입의 이벤트 구현
        public void OnDataReceived()
        {
            DataReceived?.Invoke(this, EventArgs.Empty);
            //이벤트 트리거 동작 구현
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            DataReceiver receiver = new DataReceiver();

            //콘솔 출력 람다식 구현
            receiver.DataReceived += (sender, e) =>
            {
                //사용자 이벤트 처리 작업
                Console.WriteLine("데이터를 받았습니다.");
            }; //괄호 없어도 됨


            receiver.OnDataReceived(); //메서드 호출을 통해 이벤트 트리거
        }
    }
}
