using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegateChain_easy
{
    internal class Program
    {
        delegate void Eating(string mando); //이름을 동사형으로 만드는 것이 좋음

        public static void What(string mando)
        {
            Console.WriteLine($"무슨 {mando}로 주문하시나요?");
        }

        public static void Taste1(string mando)
        {
            Console.WriteLine($"고기{mando} 먹고싶어요");
        }

        public static void Taste2(string mando)
        {
            Console.WriteLine($"야채{mando} 먹고싶어요");
        }
        static void Main(string[] args)
        {
            Eating md = new Eating(What);

            md += new Eating(Taste1);
            md += new Eating(Taste2);

            md("만두");
        }
    }
}


/*
namespace DelegateChain_easy
{
    internal class Program
    {
        delegate void Call(string number);
        public static void Today(string number)
        {
            Console.WriteLine($"오늘은 : {number}");
        }
        public static void Number(string number)
        {
            Console.WriteLine($"주민등록번호 : {number} - 1XXXXXX");
        }
        public static void Birth(string number)
        {
            Console.WriteLine($"생일 : {number}");
        }
        static void Main(string[] args)
        {
            Call call = new Call(Today);

            call += new Call(Number);
            call += new Call(Birth);

            call("981014");
        }
    }
}
*/

/*
namespace DelegateChain_easy
{
    internal class Program
    {
        delegate void ThereIsAsFire(string location);

        public static void Call119(string location)
        {
            Console.WriteLine($"소방서죠? {location}에 불이 났어요");
        }

        public static void ShootOut(string location)
        {
            Console.WriteLine($"피하세요 {location}에 불이 났어요");
        }

        public static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 나가세요");
        }

        static void Main(string[] args)
        {
            ThereIsAsFire fire = new ThereIsAsFire(Call119);
            fire += new ThereIsAsFire(ShootOut);
            fire += new ThereIsAsFire(Escape);

            fire -= new ThereIsAsFire(ShootOut);
            fire -= new ThereIsAsFire(Call119);

            fire("집");

            /*
            Fire fire= new Fire(Call);

            fire += new Fire(ShootOut);
            fire += new Fire(Escape);

            fire("집");
            Console.WriteLine();

            fire -= new Fire(Escape);

            fire("여기");
            
        }
    }
}
*/