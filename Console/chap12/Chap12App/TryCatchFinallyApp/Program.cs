using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinallyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.Write("제수를 입력하세요: ");
                string temp = Console.ReadLine(); // string으로 입력받음
                int divisor = int.Parse(temp);

                Console.Write("피제수를 입력하세요 : ");
                temp = Console.ReadLine();
                int dividend = int.Parse(temp);

                Console.WriteLine($"{divisor} / {dividend} = {Divide(divisor, dividend)}");
            }
            catch(NotImplementedException ex)
            {
                Console.WriteLine($"미구현 예외 발생 : {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"입력값 예외 발생 : {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"나누기예외 발생 : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("예외 발생 유무와 상관없이 항상 실행");
            }
        }

        private static object Divide(int divisor, int dividend)
        {
            Console.WriteLine("나누기 시작!");
            if (dividend == 0) throw new DivideByZeroException("피제수가 0이 입력되었습니다.");
            return divisor / dividend;
        }
    }
}
