using System;

namespace ConstTestApp
{
    class Program
    {
        enum Season
        {
            Spring, // = 1000 ,값 지정도 가능 지정 없으면 {0,1,2,3...}
            Summer,
            Fall,
            Winter
        }
        static void Main(string[] args)
        {
            Console.WriteLine("상수테스트");
            const double PI = 3.141592;
            Console.WriteLine($"원주율의 값은 {PI}");
            // PI =3.14 'const' 지정 값을 바꿀 수 없다.

            Season mySeason = (Season)3;

            Console.WriteLine($"지금 계절은 {mySeason}입니다.");

            int a = 0;
            Console.WriteLine($"a는 {a}");
            int? b = null;
            Console.WriteLine($"b는 {b}");

        }
    }
}
