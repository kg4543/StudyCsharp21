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
    class program : Information 
        { 
    public void input(Information[] info)
    {
        Console.Write("이름 입력: ");
        this.Name = Console.ReadLine();
        Console.Write("전화 입력: ");
        this.Tel = Console.ReadLine();
        Console.Write("주소 입력: ");
        this.Addr = Console.ReadLine();
    }

      public void select()
        {
            Console.WriteLine($"이름 입력: {Name}");
            Console.WriteLine($"전화 입력: {Tel}");
            Console.WriteLine($"주소 입력: {Addr}");
        }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // 입력 기본
            int a = 0; // 검색 반복문

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

                Information[] Info;
                Info = new Information[100];

                for (int k = 0; k < 100; k++)
                {
                    Info[k] = new Information();
                }

                Program pro = new Program();


                switch (menu)
                {
                    case "0":
                        pro.input(Info[i]);
                        i++;
                        break;

                    case "1":
                        Console.WriteLine("검색할 사용자의 이름을 적어주세요: ");
                        string selName = Console.ReadLine();
                        do
                        {
                            if (Info[a].Name == selName)
                            {
                                Info[a].select();
                            }
                            else Console.WriteLine("다시 확인부탁드립니다.");
                            a++;
                        } while (Info[a].Name == selName);
                        break;

                    case "2":
                        Console.WriteLine("수정할 사용자의 이름을 적어주세요: ");
                        string updName = Console.ReadLine();
                        do
                        {
                            if (Info[a].Name == updName)
                            {
                                Console.Write("이름 입력: ");
                                Info[a].Name = Console.ReadLine();
                                Console.Write("전화 입력: ");
                                Info[a].Tel = Console.ReadLine();
                                Console.Write("주소 입력: ");
                                Info[a].Addr = Console.ReadLine();
                                i++;
                            }
                            else Console.WriteLine("다시 확인부탁드립니다.");
                        } while (Info[a].Name == updName);

                        break;

                    case "3":
                        Console.WriteLine("삭제할 사용자의 이름을 적어주세요: ");
                        string delName = Console.ReadLine();
                        if (Info[i].Name == delName)
                        {
                            Info[i].Name = null;
                            Info[i].Tel = null;
                            Info[i].Addr = null;
                            Console.WriteLine("삭제되었습니다.");
                        }
                        else Console.WriteLine("다시 확인부탁드립니다.");
                        break;

                    case "4":
                        for (int j = 0; j < 1000; j++)
                        {
                            if (Info[j].Name == null)
                                continue;
                            Console.WriteLine($"이름 입력: {Info[j].Name}");
                            Console.WriteLine($"전화 입력: {Info[j].Tel}");
                            Console.WriteLine($"주소 입력: {Info[j].Addr}");
                        }
                        break;
                    default: Console.WriteLine("1~5 중에 하나를 선택하세요"); break;
                }



            }
        }
