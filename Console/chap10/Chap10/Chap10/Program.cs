using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10
{
    class Test { }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 80, 74, 81, 90, 34 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}번째 값 : {array[i]}");
            }

            Console.WriteLine("크기변경");
            Array.Resize(ref array, 6);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}번째 값 : {array[i]}");
            }

            Console.WriteLine("인덱스 찾기");
            int idx = Array.IndexOf(array, 81);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i - 1];
            }
            array[idx] = 50;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i - 1];
            }
            //int array = new int[5];
            /*array[0] = 80;
            array[1] = 74;
            array[2] = 81;
            array[3] = 90;
            array[4] = 34;*/

            /*Test test = new Test();
            Console.WriteLine($"Type of array : {array.GetType()}");
            Console.WriteLine($"Base Type of array: {array.GetType().BaseType}");

            for (int i = 0; i < array.Length; i++)
            {
              Console.WriteLine($"{i+1}번째 값 : {array[i]}");
            }

            Console.WriteLine("오름차순정렬");
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}번째 값 : {array[i]}");
            }

            Console.WriteLine("내림차순정렬");
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}번째 값 : {array[i]}");
            }

            int idx = Array.IndexOf(array, 34);
            Console.WriteLine($"34의 인덱스 : {idx}");

            idx = Array.IndexOf(array, 100);
            Console.WriteLine($"34의 인덱스 : {idx}");

            Console.WriteLine("배열삭제");
            Array.Clear(array, 3, 2);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}번째 값 : {array[i]}");
            }*/

            /*var idx = 0;
            foreach (var item in array)
            {
                Console.WriteLine($"{idx++}번째 값 : {item}");
            }*/

            /*Console.WriteLine($"1번째 값 : {array[0]}");
            Console.WriteLine($"2번째 값 : {array[1]}");
            Console.WriteLine($"3번째 값 : {array[2]}");
            Console.WriteLine($"4번째 값 : {array[3]}");
            Console.WriteLine($"5번째 값 : {array[4]}");*/
        }
    }
}
