using System;

namespace DelegateChainApp
{
    delegate void AllCalc(int x, int y); //대리자 선언

    class Program
    {
        static void Plus(int a, int b) { Console.WriteLine($"a + b = {a + b}"); }
        static void Minus(int a, int b) { Console.WriteLine($"a - b = {a - b}"); }
        static void Multiple(int a, int b) { Console.WriteLine($"a * b = {a * b}"); }
        static void Devide(int a, int b) { Console.WriteLine($"a / b = {a / b}"); }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating!!!");
            AllCalc allCalc = Plus;
            allCalc += Minus;
            allCalc += Multiple;
            allCalc += Devide;

            allCalc(10, 5); //대리자를 통해 method를 묶어서 한번에 호출

            allCalc -= Multiple;
            allCalc(10, 5);

            /*Plus(10,5);
            Minus(10, 5);
            Multiple(10, 5);
            Devide(10, 5);*/


        }
    }
}
