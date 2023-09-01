using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Hero
{
    internal class Knight : Hero, IBow
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
}
