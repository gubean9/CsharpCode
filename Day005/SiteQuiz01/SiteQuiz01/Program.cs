using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteQuiz01
{
    internal class Program
    {
        class Cat
        {
            private string name;
            private int age;
            private string color;

            public void setName(string _name)
            {
                name = _name;
            }

            public void setColor(string _color)
            {
                color = _color;
            }

            public void setAge(int _age)
            {
                age = _age;
            }

            public string getName()
            {
                return name;
            }
            public int getAge()
            {
                return age;
            }
            public string getColor()
            {
                return color;
            }
        }
        static void Main(string[] args)
        {
            Cat nero = new Cat();
            nero.setName("네로");
            nero.setColor("검은색");
            nero.setAge(10);

            Console.WriteLine($"이름 : {nero.getName()} 색깔 : {nero.getColor()} 나이 : {nero.getAge()}");
        }
    }
}
