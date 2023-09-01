using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //연속된 메모리 공간에 알파벳 대문자 26자 넣기

            char[] arr = new char[26]; //내가 만들었던 배열의 이름의 0번지부터(arr[0] ~ arr[N-1])

            arr[25] = 'a';

            //Console.WriteLine(arr.Length);

            //아스키코드 출력
            //Console.WriteLine((int)'a'); a의 아스키코드 출력


            char ch = 'A'; //A의 아스키코드 = 65, a의 아스키코드 = 97
            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] = ch++; //후치 = 결과 후에 계산이랫나
            }

            for(int j=0; j<arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }


            //자료형 기본타입은 값을 가지고 나머지는 객체다~ 배열도 사용자 정의타입?
        }
    }
}
