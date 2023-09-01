using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP09
{
    abstract class Hero
    {
        public int Level { get; set; }
        public abstract string Attack();
    }
    class Knight : Hero
    {
        public override string Attack()
        {
            return "공격하다";
        }
    }
    class DarkKnight : Knight
    {
        
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            DarkKnight Bob = new DarkKnight();
            Console.WriteLine(Bob.Attack());
        }
    }
}
