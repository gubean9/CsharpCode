using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "UnKnown";
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                BirthdayInfo birth = new BirthdayInfo();

                Console.WriteLine(birth.Name);
                Console.WriteLine(birth.Birthday.ToShortDateString());
                Console.WriteLine(birth.Age);


                birth.Name = "Hyuk";
                birth.Birthday = new DateTime(1998, 10, 14);

                Console.WriteLine(birth.Name);
                Console.WriteLine(birth.Birthday.ToShortDateString());
                Console.WriteLine(birth.Age);
            }
        }
    }
}
