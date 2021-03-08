using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13App
{
    delegate int MyDelegate(int a, int b); //대리자. 대신호출

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            MyDelegate callback;

            callback = new MyDelegate(calc.Plus);
            //var result = calc.Plus(3, 4);
            Console.WriteLine($"result = {callback(3,4)}");

            callback = new MyDelegate(calc.Minus);
            Console.WriteLine($"result = {callback(5,2)}");

        }
    }
}
