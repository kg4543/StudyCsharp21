using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList(new[] { 80, 74, 81, 90, 34 });
            /*array.Add(80);
            array.Add(74);
            array.Add(81);
            array.Add(90);
            array.Add(34);*/
            foreach (var item in array)
            {
                Console.Write($"{item}  ");
            }

            Console.WriteLine("<50 삽입>");
            var loc = array.IndexOf(81); // 81의 위치
            array.Insert(loc, 50); // '81의 위치에' 50을 넣음 - 81은 뒤로 밀림
            foreach (var item in array)
            {
                Console.Write($"{item}  ");
            }

            Console.WriteLine("<90 삭제>");
            array.RemoveAt(4); // 90 삭제
            foreach (var item in array)
            {
                Console.Write($"{item}  ");
            }

            Console.WriteLine("<정렬>");
            array.Sort();
            foreach (var item in array)
            {
                Console.Write($"{item}  ");
            }
        }
    }
}
