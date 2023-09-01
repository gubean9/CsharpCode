using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property01
{
    class cat
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        private int age;
        public int Age
        {
            get;
            set;
        }
        private string color;
        public string Color
        {
            get;
            set;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            cat nero = new cat();
            nero.Name = "네로";
            nero.Age = 5;
            nero.Color = "검정";

            Console.WriteLine($"이름 : {nero.Name}");
            Console.WriteLine($"나이 : {nero.Age}");
            Console.WriteLine($"색깔 : {nero.Color}");
        }
    }
}
