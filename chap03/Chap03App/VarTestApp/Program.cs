using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarTestApp
{
    class Program
    {
        //var 변수는 main method 밖에서 사용불가
        static float i = 100.5f;

        static void Main(string[] args)
        {
            var i = 100.5;
            Console.WriteLine($"정수값은 {i}입니다.");
        }
    }
}
