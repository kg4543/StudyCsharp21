using System;

namespace Chap18App
{
    class Program
    {
        string temp2 = "Global Variable string"; //var 불가
        static void Main(string[] args)
        {
            Console.WriteLine("문자열 연습 시작");

            //기본 선언
            string message1 = null;
            Console.WriteLine($"null 문자열 : {message1}");
            string message2 = string.Empty;
            Console.WriteLine($"빈값 문자열 : {message2}");
            string oldPath = "C:\\Program Files\\Bandizip"; //폴더,파일 경로
            string newPath = @"C:\Program Files\Bandizip";

            String greeting = "Hello World!"; //string이랑 차이 없음
            var temp1 = "Global Variable string"; //지역변수에서만

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string hello = new string(letters);
            Console.WriteLine($"{hello}");

            string s1 = "Hello";
            string s2 = "World";
            s1 += s2;
            Console.WriteLine($"{s1}");

            string s3 = "Hello";
            string s4 = s3;
            s3 += "world!";
            Console.WriteLine($"{s4}");

            string row = "Row1\r\nRow2\r\nRow3";
            Console.Write(row);
            Console.WriteLine("\n------------------");
            string row2 = "Row11\nRow22\nRow33";
            Console.Write(row2);
            Console.WriteLine("");
            Console.WriteLine("Row111"+Environment.NewLine+"Row222"+Environment.NewLine+"Row333");

            string oldline = "Test " +
                "Test2" +
                "Test3";
            string multiline = 
                @"New Test
    These are multiline
                      end.";
            Console.WriteLine();
            Console.Write(oldline);
            Console.WriteLine();
            Console.Write(multiline);

            Console.WriteLine($"\U0001F47D");
            var book = (lastName: "박", firstName: "상현",
                title: "이것이 C#이다.", company: "한빛미디어",
                releseDate: "2018-07-01", price: 30000, page: 812);

            Console.WriteLine($"{book.lastName}{book.firstName} 저자의 {book.title} {book.company}");
            Console.WriteLine($"{DateTime.Parse(book.releseDate).ToString("yyyy년MM월dd일")} 출간");
            Console.WriteLine($"페이지수 {book.page}, 금액: {book.price: #,###}원");

            Console.WriteLine("문자열 조작(함수사용)");
            string s5 = "Visual C# Express"; //총 19자리
            Console.WriteLine(s5);
            Console.WriteLine(s5.Trim()); //스페이스(여백) 삭제
            var s6 = s5.Trim(); // 총 17자리 "Visual C# Express"

            Console.WriteLine(s6.Substring(7)); //7번째 부터
            Console.WriteLine(s6.Substring(7, 2)); //7번째 부터 2자리

            Console.WriteLine(s6.Replace("C#", "Basic")); //글자 변환
            Console.WriteLine(s6.Replace((s6.Substring(7, 2)), "Basic"));

            Console.WriteLine(s6.IndexOf("C")); //위치 7
            Console.WriteLine(s6.Length); //길이 17
            Console.WriteLine(s6.ToLower()); //소문자
            Console.WriteLine(s6.ToUpper()); //대문자

            // null문자열 빈문자열
            Console.WriteLine("null/빈문자열 처리");
            string str = "Hello";
            string nullstr = null;
            string emptystr = string.Empty;

            Console.WriteLine(str + nullstr); // hello 출력
            Console.WriteLine(nullstr == emptystr);
            try
            {
                Console.WriteLine(nullstr.Equals(emptystr)); //예외발생
                Console.WriteLine(emptystr.Length); //0
                Console.WriteLine(nullstr.Length); //예외발생
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }

            
        }
    }
}
