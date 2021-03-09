using System;
using System.Threading;

namespace Chap19App
{
    class Program
    {
        static void Dosomething()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Dosomething : {i}");
                Thread.Sleep(10); // 1000 = 1 초
            }
        }

        static void SomethingHappened()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"SomethingHappened : {i}");
                Thread.Sleep(10); // 1000 = 1 초
            }
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(Dosomething));
            Thread thread1 = new Thread(SomethingHappened);
            try
            {
                Console.WriteLine("Thread Start!");
                thread.Start();
                thread1.Start();

                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"Main thread : {i}");
                    Thread.Sleep(10);

                    if (i == 10)
                        thread.Abort(); // 중간에 종료
                }

                Console.WriteLine("스레드 종료 대기...");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                thread.Join();
                thread1.Join();

                Console.WriteLine("스레드 종료...");
            }

            
        }
    }
}
