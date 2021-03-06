﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCastApp
{
    class 포유류
    {
        public void 키우다()
        {
            Console.WriteLine("키우다!!");
        }
    }

    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍!");
        }
    }
    class 고양이 : 포유류
    {
        public void 야옹()
        {
            Console.WriteLine("야옹~");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            포유류 왕 = new 포유류();
            왕.키우다();
            //왕.멍멍(); 불가능
            왕 = new 강아지();
            왕.키우다();
            강아지 구피 = new 강아지();
            구피.키우다();

            if (왕 is 강아지)
            {
                구피 = 왕 as 강아지; //41번 줄에 구피에 값이 없어 여기서 값을 지정받음
                구피.키우다();
                구피.멍멍();
                Console.WriteLine("오즈");
            }



            강아지 뽀삐 = null;
            //뽀삐 = (강아지)new 포유류();
            if (뽀삐 is 포유류)
            {
                뽀삐 = new 포유류() as 강아지;
                뽀삐.키우다();
                뽀삐.멍멍();
            }
            //고양이 키티 = (고양이)new 포유류(); 

        }
    }
}
