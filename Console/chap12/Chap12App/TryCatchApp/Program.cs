using System;

namespace TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)  // '< 5'는 실행 시 오류 
                {
                    Console.WriteLine($"{i} 번째 값 : {arr[i]}");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발견!!!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"예외발견!!!");
            }
            Console.WriteLine($"나머지 일처리");

            string strVal = "Hello worle";
            int idx = strVal.IndexOf("W"); //6
            Console.WriteLine($"{strVal}");

            

            try
            {
                string stVal = null;
                string st = stVal.Substring(6, 5);
                Console.WriteLine($"자른문자 : {stVal}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"원본문자열에 값을 입력하시어");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($"원본문자열을 초기화하세요");
            }
            catch (Exception)
            {
                Console.WriteLine($"기타 예외 발생");
            }
        }

    }
}
