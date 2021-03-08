using System;

namespace InfiniteLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            long idx = 0;
            for ( ; ; ) //무한루프
            {
                Console.WriteLine($"{idx++}");
            }
            while(true) //무한루프
            {
                Console.WriteLine($"{idx++}");
            }
        }
    }
}
