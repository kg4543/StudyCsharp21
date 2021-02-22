using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntConversionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            short shmaxval = short.MaxValue;
            int incastval = 0;
            incastval = shmaxval;
            Console.WriteLine($"short값 변환한 int값은 {incastval}");

            incastval += 5;  //32767+5
            short shcastval = (short)incastval;
            Console.WriteLine($"short값 변환한 int값은 {shcastval}");  //overflow -32764

            float flval = 3.141592f; // f or F 를 써야함
            incastval = (int)flval;
            Console.WriteLine($"float값 변환한 int값은 {incastval}");
            double dlval = incastval; //3
            Console.WriteLine($"int값 변환한 double값은 {dlval}");

            object obj = 20; //boxing
            int inUnboxingVal = (int)obj; // unboxing

            string strVal = "200";
            int result = int.Parse(strVal) * 3; //parse: 문자형을 숫자형으로 형 변환
            Console.WriteLine($"200 * 3 = {result}");
        }
    }
}
