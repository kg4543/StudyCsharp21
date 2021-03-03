using System;
using System.IO;

namespace GenDirFireApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string strDir = "D:\\GitRepository\\StudyCsharp21\\SampleDir"; //폴더,파일 생성 테스트 폴더
            string strTargetDir = "SubFolder"; //생성하고자하는 폴더명
            string strTagetFile = "readme.txt";

            string targetPath = strDir + "\\" + strTargetDir;
            //string targetPath = $(strDir\\strTargetDir);

            if (Directory.Exists(targetPath))
            {
                Console.WriteLine("이미 폴더가 존재합니다.");
            }
            else
            {
                Directory.CreateDirectory(targetPath);
                Console.WriteLine("폴더 생성 성공!!");
            }

            targetPath += $"\\{strTagetFile}";
            if (File.Exists(targetPath))
            {
                Console.WriteLine("이미 파일이 존재합니다.");
            }
            else
            {
                File.Create(targetPath).Close();
                Console.WriteLine("파일 생성 성공!!");
            }
        }
    }
}
