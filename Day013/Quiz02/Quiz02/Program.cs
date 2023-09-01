using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz02
{
    internal class Program
    {
        public string Login(Dictionary<string, string> dic, string a, string b)
        {
            if (dic["ID"] == a && dic["PW"] == b)
            {
                return "로그인에 성공했습니다";
            }
            else
            {
                return "로그인에 실패했습니다";
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>
            {
                { "ID", "PW" },
                { "user", "pw" }
            };
            string id, pw;

            Console.Write("ID : ");
            id = Console.ReadLine();
            Console.Write("PW : ");
            pw = Console.ReadLine();

            Console.WriteLine(Login(dic, id, pw));
        }
    }
}
