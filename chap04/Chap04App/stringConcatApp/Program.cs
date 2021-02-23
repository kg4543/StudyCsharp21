using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 더하기");
            Console.WriteLine(123+456); //579
            Console.WriteLine("123" + 456); //123456 문자열이 하나라도 있으면 문자열로 바뀜
            Console.WriteLine("123" + "456"); //123456
            Console.WriteLine($"123{456}"); //123456 C# 6.0이후 문자열 만드는 법
            var p = 456;
            Console.WriteLine(123 + p);
            Console.WriteLine("123" + p); 
            Console.WriteLine("123" + "456"); 
            Console.WriteLine($"123{p}");

            // 관계 연산자
            int a = 30, b = 30;
            Console.WriteLine("관계 연산자");
            Console.WriteLine(a < b); // False
            Console.WriteLine(a > b); // False
            Console.WriteLine(a != b); // False
            Console.WriteLine(a >= b); // True
            Console.WriteLine(a == b); // True

            // 논리 연산자
            Console.WriteLine("논리 연산자");
            Console.WriteLine(10 > 9 && a > 0); // True
            Console.WriteLine(a > b || b > 0); // True
            Console.WriteLine(!(a > b || b > 0)); //False

            // 조건 연산자 단항 if문을 대체가능
            int c = 30;
            string result = c == 30 ? "30 O":"30 X";
            /*if (c == 30)
                result = "삼십이다.";
            else
                result = "삼십이 아니네?";*/
            Console.WriteLine(result);

            Console.WriteLine("NULL 병합연산자");
            int? d = null;
            Console.WriteLine($"{d ?? 0}"); //d가 NULL이면 0으로 출력
        }
    }
}
