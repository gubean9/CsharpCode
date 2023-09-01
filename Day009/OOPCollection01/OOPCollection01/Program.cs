using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCollection01
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public Person(string name)
        {
            Name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Jane = new Person("제인");
            Person Tom = new Person("톰");
            Person Hyuk = new Person("혁");

            List<Person> list = new List<Person>();
            list.Add(Jane);
            list.Add(Tom);
            list.Add(Hyuk);

            //제거
            list.Remove(Tom);

            //추가?
            Person Sam = new Person("샘");
            list.Add(Sam);

            ////정렬해서 출력
            //Array.Sort(List);
            //List<int> list2 = new List<int>() { 9, 8, 6, 5 };
            //list2.Sort();
            //list.Sort();
            list.Sort((a,b) =>  a.Name.CompareTo(b.Name));

            foreach(Person p in list)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}
