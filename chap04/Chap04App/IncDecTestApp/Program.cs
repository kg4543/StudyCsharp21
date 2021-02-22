using System;

namespace IncDecTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("증감연산자 테스트");

            int result = 26; // 26
            Console.WriteLine($"현재 숫자는 {result}");
            result += 3; // 29
            Console.WriteLine($"현재 숫자는 {result}");
            result -= 10; // 19
            Console.WriteLine($"현재 숫자는 {result}"); 
            Console.WriteLine($"현재 숫자는 {result++}"); // 19 출력 후 20으로 증가
            Console.WriteLine($"현재 숫자는 {++result}"); // 21로 증가 후 출력
            Console.WriteLine($"현재 숫자는 {result--}"); // 21 출력 후 20으로 감소
            Console.WriteLine($"현재 숫자는 {--result}"); // 19로 감소 후 출력
            result += 1; //20
            Console.WriteLine($"현재 숫자는 {result}");

        }
    }
}
