using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Information
    {
        private string _name;
        private string _tel;
        private string _addr;
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Tel
        {
            get { return this._tel; }
            set { this._tel = value; }
        }
        public string Addr
        {
            get { return this._addr; }
            set { this._addr = value; }
        }
}

    class Program
    {
       
        static void Main(string[] args)
        {
            int i = 0; // 입력 기본
            int a = 0; // 검색 반복문
            Information[] Info;
            Info = new Information[10];

            for (int k = 0; k < 10; k++)
            {
                Info[k] = new Information();
            }

            while (true)
            {
                Console.WriteLine("0. 주소 입력");
                Console.WriteLine("1. 주소 검색");
                Console.WriteLine("2. 주소 수정");
                Console.WriteLine("3. 주소 삭제");
                Console.WriteLine("4. 주소 전체 출력");
                Console.WriteLine("5. 프로그램종료");
                Console.Write("메뉴를 선택하세요 >>>");
                string menu = Console.ReadLine();
                if (menu == "5") break;

                switch (menu)
                {
                    case "0":
                        Console.WriteLine("-------------------------");
                        Console.Write("이름 입력: ");
                        Info[i].Name = Console.ReadLine();
                        Console.Write("전화 입력: ");
                        Info[i].Tel = Console.ReadLine();
                        Console.Write("주소 입력: ");
                        Info[i].Addr = Console.ReadLine(); 
                        Console.WriteLine("-------------------------");
                        i++;
                        break;

                    case "1":
                        Console.WriteLine("검색할 사용자의 이름을 적어주세요: ");
                        string selName = Console.ReadLine();
                        for (a = 0; Info[a].Name != selName; a++) ;
                            if (Info[a].Name == selName)
                            {
                                Console.WriteLine("-------------------------");
                                Console.WriteLine($"이름 : {Info[a].Name}");
                                Console.WriteLine($"전화 : {Info[a].Tel}");
                                Console.WriteLine($"주소 : {Info[a].Addr}");
                                Console.WriteLine("-------------------------");
                            }
                            else Console.WriteLine("다시 확인부탁드립니다.");
                        break;

                    case "2":
                        Console.WriteLine("수정할 사용자의 이름을 적어주세요: ");
                        string updName = Console.ReadLine();
                        for (a = 0; Info[a].Name != updName; a++) ;
                        if (Info[a].Name == updName)
                            {
                                Console.WriteLine("-------------------------");
                                Console.WriteLine($"이름 : {Info[a].Name}");
                                Console.WriteLine($"전화 : {Info[a].Tel}");
                                Console.WriteLine($"주소 : {Info[a].Addr}");
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("수정할 내용을 적어주세요: ");
                                Console.Write("이름 입력: ");
                                Info[a].Name = Console.ReadLine();
                                Console.Write("전화 입력: ");
                                Info[a].Tel = Console.ReadLine();
                                Console.Write("주소 입력: ");
                                Info[a].Addr = Console.ReadLine();
                                Console.WriteLine("-------------------------");
                            }
                            else Console.WriteLine("다시 확인부탁드립니다.");
                        break;

                    case "3":
                        Console.WriteLine("삭제할 사용자의 이름을 적어주세요: ");
                        string delName = Console.ReadLine();
                        for(a = 0; Info[a].Name != delName; a++) ;
                        if (Info[a].Name == delName)
                            {
                                Console.WriteLine("-------------------------");
                                Info[a].Name = null;
                                Info[a].Tel = null;
                                Info[a].Addr = null;
                                Console.WriteLine("삭제되었습니다.");
                                Console.WriteLine("-------------------------");
                            }
                            else Console.WriteLine("다시 확인부탁드립니다.");
                        break;

                    case "4":
                        for (int j = 0; j < 10; j++)
                        {
                            if (Info[j].Name == null)
                                continue;
                            Console.WriteLine("-------------------------");
                            Console.WriteLine($"이름 입력: {Info[j].Name}");
                            Console.WriteLine($"전화 입력: {Info[j].Tel}");
                            Console.WriteLine($"주소 입력: {Info[j].Addr}");
                            Console.WriteLine("-------------------------");
                        }
                        break;
                        
                    default: Console.WriteLine("1~5 중에 하나를 선택하세요");
                             Console.Clear();
                            break;
                }
            }
        }
        }
    }

