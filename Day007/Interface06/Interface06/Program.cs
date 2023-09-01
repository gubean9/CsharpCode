using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface06
{
    interface ILogger
    {
        void WriteLog(string Message);
    }

    interface IFormattableLogger : ILogger //상속 X 구현 O
    {
        
    }

    //interface끼리는 구현받아도 뭐 할 필요가 없다고??? 뭔소리고
    class ConsoleLogger2 : IFormattableLogger //이건 상속인가 모르겠음 근데 구현인듯
    {
        public void WriteLog(string Message)
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
