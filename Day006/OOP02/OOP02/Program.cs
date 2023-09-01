using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    //상속(완벽한 복사??)

    class Car
    {
        public string name;
        protected int spped;
        private string brand;
        //지시자 세 개


        public void run()
        {
            Console.WriteLine("차가 달리다");
        }
    }
    class SuperCar : Car
    {
        public SuperCar()
        {
            this.spped = 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SuperCar sc = new SuperCar();
            sc.run();
            sc.name = "차";
        }
    }
}
