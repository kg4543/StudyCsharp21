using System;
using System.IO;

namespace TextFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\GitRepository\StudyCsharp21\SampleDir\SubFolder\a.dat"; //텍스트 파일 생성위치

            StreamWriter sw = null; 

            try
            {
                sw = new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate,FileAccess.Write));
                sw.WriteLine($"int.MaxValue = {int.MaxValue}");
                sw.WriteLine("Hello, World!");
                sw.WriteLine($"unit.MaxValue = {uint.MaxValue}");
                sw.WriteLine("안녕하세요!!");
                sw.WriteLine($"unit.MaxValue = {double.MaxValue}");

                Console.WriteLine("파일 생성");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"파일 쓰기 예외발생 : {ex.Message}");
            }
            finally
            {
                sw.Close();
            }

            StreamReader sr = null;
            sr = new StreamReader(new FileStream(filePath, FileMode.Open,FileAccess.Read));
            Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");

            while (sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
