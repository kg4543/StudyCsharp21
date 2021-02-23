using System;

namespace ForeachTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sources = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for문
            for (int i = 0; i < sources.Length; i++)
            {
                Console.WriteLine($"sources[{i}] = {sources[i]}");
            }
            //foreach문
            var idx = 0;
            foreach (var item in sources)
            {             
                    Console.WriteLine($"sources[{idx++}] = {item}");
            }

            foreach (var item in sources)
            {
                if(item % 3 == 0)
                {
                    Console.WriteLine($"{item}은 3의 배수이다.");
                }
                else
                {
                    Console.WriteLine($"{item}은 3의 배수가 아니다.");
                }
            }
        }
    }
}
