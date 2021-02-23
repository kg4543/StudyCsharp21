using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
/*            Console.WriteLine("While문 처리");
            int a = 10;
            while (a > 0)
            {
                Console.WriteLine($"{a}");
                a -= 2; //후치,전치 생각
            }

            do
            {
                Console.WriteLine($"{a}");
                a += 2;
            }while (a < 10); //한번은 실행시키고 반복결정
            Console.WriteLine("While문 종료!\n");

            Console.WriteLine("for문 처리");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("for문 종료!\n");*/

            Console.WriteLine("구구단 시작");
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine($"\n{i}단 시작");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i} X {j} = {i*j}\t");
                }
            }
            Console.WriteLine("\n구구단 종료");
        }
    }
}
