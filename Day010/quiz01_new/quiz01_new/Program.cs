using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz01_new
{
    //1. IWeapon interface
    interface IWeapon
    {
        void Attack();
    }
    //2. IBow interface, methode --> Attack()
    interface IBow : IWeapon
    {

    }
    //3. Hero => member 변수 Name Property
    class Hero
    {
        public string Name { get; set; }
    }
    //4. Knight => 아더 기사를 생성해야 함
    class Knight : Hero, IBow
    {
        public Knight(string name)
        {
            Name = name;
        }
        public void Attack()
        {
            Console.WriteLine("활을 쏩니다");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Knight AR = new Knight("아더");
            Console.WriteLine(AR.Name);
            AR.Attack();
        }
    }
}
