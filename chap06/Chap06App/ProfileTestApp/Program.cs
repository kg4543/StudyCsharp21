using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("김구겸", "010-4521-8100");

            PrintProfile(null, "010-4568-8745");
        }

        public static void PrintProfile(string name,string phone)
        {
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력하세요");
                return;
            }
            //프로필 출력
            Console.WriteLine($"이름 : {name}, 폰번호 {phone}");
        }
    }
}
