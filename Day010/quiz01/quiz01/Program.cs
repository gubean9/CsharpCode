using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz01
{
    interface Weapon
    {
        void Attack();
    }
    interface Bow : Weapon
    {

    }
    class Hero
    {
        public string Name { get; set; }
    }
    class Knight : Hero, Bow
    {
        public Knight(string name)
        {
            Name = name;
        }
        public void Attack()
        {
            Console.WriteLine(Name + "가 활을 쏩니다");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight k = new Knight("아더");
            //k.Name = "아더";
            k.Attack();
        }
    }
}
