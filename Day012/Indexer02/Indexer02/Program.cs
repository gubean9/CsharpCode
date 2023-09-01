using System;

namespace Indexer02
{
    class MyList
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        //인덱서로 만들기
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resize : {array.Length}");
                }
                array[index] = value;
            }

            public int Length
        {
            get { return array.Length; }

        }
    }

}


internal class Program
{
    static void Main(string[] args)
    {
        MyList list = new MyList(); //일반 클래스

        for (int i = 0; i < 5; i++)
        {
            list[i] = i; //C#만 사용 가능한 문법
        }

        for (int i = 0; i < list.Length;)
        }
}
}
