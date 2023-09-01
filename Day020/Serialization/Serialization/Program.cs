using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Serialization
{
    class NameCard
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "a.json";
            using (Stream ws = new FileStream(path, FileMode.Create)) //using 사용시 close를 사용 안해도 됨
            {
                NameCard nc = new NameCard();
                nc.Name = "홍길동";
                nc.Phone = "010-0000-0000";
                nc.Age = 20;

                //Console.WriteLine(nc.Name);
                string jsonString = JsonSerializer.Serialize<NameCard>(nc); //개체 직렬화함
                //Console.WriteLine(jsonString);
                byte[] jsonBytes = Encoding.UTF8.GetBytes(jsonString);
                ws.Write(jsonBytes, 0, jsonBytes.Length);
            }
            //친구 컴퓨터로 전송 => Network Programming

            using(Stream rs = new FileStream(path, FileMode.Open))
            {
                byte[] jsonBytes = new byte[rs.Length];
                rs.Read(jsonBytes, 0, jsonBytes.Length);
                string jsonString = Encoding.UTF8.GetString(jsonBytes);

                Console.WriteLine(jsonString);

                NameCard nc2 = JsonSerializer.Deserialize<NameCard>(jsonString);

                Console.WriteLine(nc2.Name);
                Console.WriteLine(nc2.Phone);
                Console.WriteLine(nc2.Age);
            }
        }
    }
}
