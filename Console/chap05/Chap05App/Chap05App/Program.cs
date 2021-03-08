using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap05App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("(quit 입력 시 종료)");
                Console.Write("\n수를 입력하세요 : ");
                string line = Console.ReadLine(); //콘솔에서 입력값을 변수할당 , 문자열로 받기때문에 형변환 필요

                if (line == "quit") break;

                int number = 0;
                int.TryParse(line,out number); //int.Parse(line); //TryParse(입력값, out 출력값): 에러값을 넣을 경우 '0'으로 출력
                // todo 아래로직 수정
                if(number > 0)
                {
                    if (number % 2 == 0)
                        Console.WriteLine("짝수\n");
                    else
                        Console.WriteLine("홀수\n");

                }
                else
                {
                    Console.WriteLine("0보다 작은 수");
                }
            }

            Console.WriteLine("계산종료");
        }
    }
}
