using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Common.Story story = new Common.Story();
            story.initStory();

            Hero.Knight arthur = new Hero.Knight("아더");
            Console.WriteLine($"{arthur.Name}가 {arthur.Attack()}");
        }
    }
}
