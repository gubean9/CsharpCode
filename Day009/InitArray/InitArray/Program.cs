﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//380p
//배열을 초기화하는 세가지 방법
namespace InitArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //선언과 동시 초기화
            string[] array1 = new string[3] { "안녕", "Hello", "Halo" };

            //선언 후 초기화
            array1[0] = "안녕";
            array1[1] = "Hello";
            array1[2] = "Halo";

            //배열의 용량을 생략 가능
            string[] array2 = new string[] { "안녕", "Hello", "Halo" };

            //new를 생략 가능
            string[] array3 = { "안녕", "Hello", "Halo" };

            foreach (string s in array3)
                Console.WriteLine(s);


            int[] arr1 = new int[3] { 1, 2, 3 };
            int[] arr2 = new int[] { 1, 2, 3 };
            int[] arr3 = {1, 2, 3 }; //가능하다

            Console.WriteLine($"Type : {arr3.GetType()}");
            Console.WriteLine($"Type : {array3.GetType()}");
            Console.WriteLine($"Type : {arr3.GetType().BaseType}");
            Console.WriteLine($"Type : {arr3.GetType().BaseType}");
        }
    }
}
