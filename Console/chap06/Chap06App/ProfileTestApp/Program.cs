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

            if (PrintProfile(null, "010-1111-2222") == -1)
            {
              
            }

            //PrintProfile(phone:"010-2222-1111",name:"홍길동");
            PrintProfile("강백호",null);

        }

        public static int PrintProfile(string name, string phone /*= "010-7979-7979"*/)
        {
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("출력을 실패하였습니다.");
                Console.WriteLine("이름을 정확히 입력하세요");
                return -1;
            }
            if (string.IsNullOrEmpty(phone))
            {
                Console.WriteLine("출력을 실패하였습니다.");
                Console.WriteLine("전화번호를 정확히 입력하세요");
                return -2;
            }
            //프로필 출력
            Console.WriteLine($"이름 : {name}, 폰번호 {phone}");
            return 0;
        }
    }
}
