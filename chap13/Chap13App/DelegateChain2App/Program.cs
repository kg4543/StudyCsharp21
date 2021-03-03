using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChain2App
{
    class Program
    {

        delegate void ThereIsAFire(string location); //대리자 선언

        static void Call119 (string location)
        {
            Console.WriteLine($"Calling....소방서죠? 불이 났어요,여기 주소는 {location}입니다.");
        }
        static void ShotOut(string location)
        {
            Console.WriteLine($"불이야 ! {location}에 불이 났어요.");
        }
        static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 나가세요.");
        }
        static void Main(string[] args)
        {
            ThereIsAFire fire = new ThereIsAFire(ShotOut);
            fire += new ThereIsAFire(Escape);
            fire += Call119;

            fire("문현동 크리스탈PC방");
        }
    }
}
