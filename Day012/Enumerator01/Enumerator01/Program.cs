using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator01
{
    class My
    {
        private int[] numbers = { 1, 2, 3, 4 }; //private 못가져옴 가져올거면 public

        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;
            yield return numbers[3]; //동작하지 못하는 코드
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new My();
            foreach(var item in obj)
            {
                Console.WriteLine(item);
            }
        }
    }
}
