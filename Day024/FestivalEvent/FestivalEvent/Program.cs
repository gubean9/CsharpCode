using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalEvent
{
    public delegate void FestivalStartedEventHandler(object sender, EventArgs e);

    public class Festival
    {
        //FestivalStartedEventHandler 타입의 이벤트를 여기에 선언

        public void StartFestival()
        {
            //이벤트 여기서 트리거
        }

        //축제 시작 이벤트를 구독하고 "축제가 시작되었습니다" 라는 메세지를 출력하는 메서드 작성

        //축제 시작 이벤트를 구독하고 "음악을 연주합니다" 라는 메세지를 출력하는 메서드 작성
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Festival festival = new Festival();
            //축제 시작 이벤트를 구독하는 메서드들을 호출

            festival.StartFestival(); //이 호출로 이벤트 트리거
        }
    }
}
