using AddressBookApp;
using System;
using System.Collections.Generic;


namespace Chap99
{
    class MAinApp
    {
        static void Main(string[] args)
        {
            try
            {
                AddressManager manager = new AddressManager();
                manager.listAddress = new List<AddressInfo>();

                DataFileManager fileManager = new DataFileManager();
                manager.listAddress = fileManager.ReadData();

                while (true)
                {
                    Console.Clear();

                    manager.PrintMenu();
                    int menuNum = manager.SelectMenu();
                    //Console.WriteLine($"선택된 메뉴번호 : {menuNum}");
                    switch (menuNum)
                    {
                        case 1: //주소입력
                            Console.Clear();
                            manager.inputAddress();
                            break;
                        case 2: //주소검색
                            Console.Clear();
                            manager.SearchAddress();
                            break;
                        case 3: //주소수정
                            Console.Clear();
                            manager.UpdateAddress();
                            break;
                        case 4: //주소삭제
                            Console.Clear();
                            manager.DeleteAddress();
                            break;
                        case 5: //주소 전체 출력
                            Console.Clear();
                            manager.PrintAddress();
                            break;
                        case 6: // 주소록을 다시 파일에 씀
                            fileManager.WriteData(manager.listAddress);
                            Environment.Exit(0); //종료
                            break;
                        default: //0은 여기서
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
        }
    }
}
