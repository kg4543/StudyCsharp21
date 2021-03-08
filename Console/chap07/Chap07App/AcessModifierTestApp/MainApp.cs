using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifierTestApp
{
    class Boiler
    {
        private int temp = 5; //물 온도 접근제한자: public, protected, public

        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 50)
            {
                Console.WriteLine("물 온도를 조절 중 입니다...");
                Random rnd = new Random();
                int modTemp = rnd.Next(5,10);
                if(temp < 30)
                {
                    this.temp = temp + modTemp;
                }
                if (temp > 50)
                {
                    this.temp = temp - modTemp;
                }
                return;
            }
            else
            {
                this.temp = temp;
            }
        }
        public int GetTemp()
        {
            return this.temp;
        }
        public void TurnOnBoiler()
        {
            Console.WriteLine("물 온도를 올립니다.");
        }
        public void TurnOffBoiler()
        {
            Console.WriteLine("물 온도를 내립니다.");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kitu = new Boiler();

            var curTemp = kitu.GetTemp();
            Console.WriteLine($"현재 물 온도는 {curTemp}℃입니다.");

            for (curTemp = kitu.GetTemp(); (curTemp < 30 || curTemp > 50);)
            { 
            if (kitu.GetTemp() >= 50)
            {
                kitu.TurnOffBoiler();
            }
            else if(kitu.GetTemp() <= 30)
            {
                kitu.TurnOnBoiler();
            }
            else
            {
                Console.WriteLine($"적정온도입니다. 현재 물 온도는 {curTemp}℃입니다.");
            }
                kitu.SetTemp(curTemp);
                curTemp = kitu.GetTemp();
                Console.WriteLine($"현재 물 온도는 {curTemp}℃입니다.");
            }
            Console.WriteLine("물 온도조절이 완료되었습니다!!!");
        }
        
    }
}
