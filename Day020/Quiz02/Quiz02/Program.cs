using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Quiz02
{
    class Student
    {
        public int STID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "student.json";
            using (Stream st = new FileStream(path, FileMode.Create))
            {
                Student std = new Student();
                std.STID = 12345;
                std.Name = "이순신";
                std.Major = "스마트팩토리";

                string jsonString = JsonSerializer.Serialize<Student>(std);
                //Console.WriteLine(jsonString);
                byte[] jsonBytes = Encoding.UTF8.GetBytes(jsonString);
                st.Write(jsonBytes, 0, jsonBytes.Length);
            }

            using (Stream st2 = new FileStream(path, FileMode.Open))
            {
                byte[] jsonBytes = new byte[st2.Length];
                st2.Read(jsonBytes, 0, jsonBytes.Length);
                string jsonstring = Encoding.UTF8.GetString(jsonBytes);

                Student std2 = JsonSerializer.Deserialize<Student>(jsonstring);

                Console.WriteLine($"학번 : {std2.STID}");
                Console.WriteLine($"이름 : {std2.Name}");
                Console.WriteLine($"전공 : {std2.Major}");
            }

        }
    }
}
