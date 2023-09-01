using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//480p
namespace UsingCallback
{
    delegate int Compare(int a, int b);
 
    internal class Program
    {
        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }
        static void BubbleSort(int[] dataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < dataSet.Length; i++)
            {
                for (j = 0; j < dataSet.Length - (i + 1); j++)
                {
                    if (Comparer(dataSet[j], dataSet[j + 1]) > 0)
                    {
                        temp = dataSet[j + 1];
                        dataSet[j + i] = dataSet[j];
                        dataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.Write("오름차순 : ");
            BubbleSort(array, new Compare(AscendCompare));
            
            for(int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine();


            int[] array2 = { 7, 2, 8, 10, 11 };

            Console.Write(("내림차순 : "));
            BubbleSort(array, new Compare(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
                Console.Write(array2[i] + " ");

            Console.WriteLine();
        }
    }
}
