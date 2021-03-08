using System;

namespace OverloadTestApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기!");

            int x = Calculator.Plus(3, 404);
            float y = Calculator.Plus(21.45f,123.1f);
            double z = Calculator.Plus(3.14, "404.5");
            Console.WriteLine($"{x}+{y}+{z}={x+y+z}");

            int total = 0;
            total = Sum(1,2) + Sum(1,2,3) + Sum(1,2,3,4); //가변길이 매개변수 'params int [] args'활용
            Console.WriteLine($"합계는 {total}");
        }

        private static int Sum(params int [] args)
        {
            int result = 0;
            foreach (int item in args)
            {
                result += item;
            }
            return result;
        }
        #region Plus_overloading
        private static int Plus(int v1, int v2)
        {
            int result = v1 + v2;
            Console.Write("int 오버로딩: ");
            Console.WriteLine($"{result}");
            return result;
        }
        private static float Plus(float v1, float v2)
        {
            float result = v1 + v2;
            Console.Write("float 오버로딩: ");
            Console.WriteLine($"{result}");
            return result;
        }
        private static double Plus(double v1, double v2)
        {
            double result = v1 + v2;
            Console.Write("double 오버로딩: ");
            Console.WriteLine($"{result}");
            return result;
        }
        private static double Plus(double v1, string v2)
        {
            double.TryParse(v2, out double p2);
            double result = v1 + p2;
            Console.Write("string 오버로딩: ");
            Console.WriteLine($"{result}");
            return result;
        }
        #endregion
    }
}
