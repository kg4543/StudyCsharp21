using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap04App
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = 37656234;
            if (values % 2 ==0)
            {
                Console.WriteLine("짝수 입니다.");
            }
            else
            {
                Console.WriteLine("홀수 입니다.");
            }
            if (values % 17 == 0)
            {
                Console.WriteLine("17의 배수 입니다.");
            }
            else
            {
                Console.WriteLine("17의 배수가 아닙니다.");
            }
        }
    }
}
