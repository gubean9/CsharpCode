using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementLambda
{
    internal class Program
    {
        delegate string Concatenate(string[] args);
        static void Main(string[] args)
        {
            Concatenate concat = (arr) => //arr은 아무거나 바꿔도 됨 대신 foreach문도 같이 수정~
            {
                string result = "";
                foreach(string s in arr)
                    result += s;
                return result; //중괄호 없으면 없어도 가능하나 중괄호 있으면 꼭 써야 빠져나감
            };
            Console.WriteLine(concat(args));
        }
    }
}
