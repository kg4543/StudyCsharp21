using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22;
            int b = 3;
            /*int val = 0;
            int rem = 0;*/
            Divide(a,b,out int val,out int rem);

            Console.WriteLine($"{a}/{b}={val}\n{a}%{b}={rem}");

            bool isSuceed = int.TryParse("1000.74", out int result); // False
            Console.WriteLine($"변환결과 {isSuceed}, result값{result}");
        }
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;

            return;
        }
    }
}
