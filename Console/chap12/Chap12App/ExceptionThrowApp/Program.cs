using System;

namespace ExceptionThrowApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoSomething(13);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"예외발생 : {ex.Message}");
            }
        }

        private static void DoSomething(int v)
        {
                if (v <=10)
                {
                    Console.WriteLine($"v^2 = {v * v}");
                }
                else
                {
                    throw new Exception("10보다 큰 값은 계산할 수 없습니다.");
                }   
        }
    }
}
