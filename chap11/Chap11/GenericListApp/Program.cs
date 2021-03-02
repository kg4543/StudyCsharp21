using System;
using System.Collections.Generic;

namespace GenericListApp
{
    class Program
    {

        /// <summary>
        /// 실무에서 가장 많이 사용되는 컬렉션1
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            list.Reverse();
            Console.WriteLine("descending 역정렬");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            list.Insert(3, 20);
            Console.WriteLine("값 추가");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            list.RemoveAt(5);
            Console.WriteLine("값 제거");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            List<string> srtList = new List<string>() { "일", "이", "삼", "사", "오" };
            Console.WriteLine("문자열 리스트");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
