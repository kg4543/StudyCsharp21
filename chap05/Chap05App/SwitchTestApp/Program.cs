using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\n(종료 입력 시 시스템을 종료합니다.)");
                Console.Write("\n요일을 입력하세요 : ");
                string line = Console.ReadLine();

                if (line == "종료") break;

                switch (line)
                {
                    case "월요일": Console.WriteLine("한 주의 시작"); break;
                    case "화요일": Console.WriteLine("재미없는 화요일"); break;
                    case "수요일": Console.WriteLine("외식하는 날"); break;
                    case "목요일": Console.WriteLine("영화보는 날"); break;
                    case "금요일": Console.WriteLine("불금"); break;
                    case "토요일": Console.WriteLine("즐토"); break;
                    case "일요일": Console.WriteLine("쉬어야돼..."); break;
                    default: Console.WriteLine("모르겟어요"); break;
                }
            }
            Console.WriteLine("시스템을 종료합니다.");
        }
        }
}
