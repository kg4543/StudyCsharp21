using System;


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
        public void inputData()
        {
            Console.WriteLine("-------------------------");
            Console.Write("이름 입력: ");
            Name = Console.ReadLine();
            Console.Write("전화 입력: ");
            Tel = Console.ReadLine();
            Console.Write("주소 입력: ");
            Addr = Console.ReadLine();
            Console.WriteLine("-------------------------");
        }
        public void selectData(string selName)
        {
                if (Name == selName)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"이름 : {Name}");
                Console.WriteLine($"전화 : {Tel}");
                Console.WriteLine($"주소 : {Addr}");
                Console.WriteLine("-------------------------");
            }
            else Console.WriteLine("다시 확인부탁드립니다.");
        }

        public void modData(string modName)
        {
            if (Name == modName)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"이름 : {Name}");
                Console.WriteLine($"전화 : {Tel}");
                Console.WriteLine($"주소 : {Addr}");
                Console.WriteLine("-------------------------");
                Console.WriteLine("-------------------------");
                Console.WriteLine("수정할 내용을 적어주세요: ");
                Console.Write("이름 입력: ");
                Name = Console.ReadLine();
                Console.Write("전화 입력: ");
                Tel = Console.ReadLine();
                Console.Write("주소 입력: ");
                Addr = Console.ReadLine();
                Console.WriteLine("-------------------------");
            }
            else Console.WriteLine("다시 확인부탁드립니다.");
        }
        public void deletData(string delName)
        {
            if (Name == delName)
            {
                Console.WriteLine("-------------------------");
                Name = null;
                Tel = null;
                Addr = null;
                Console.WriteLine("삭제되었습니다.");
                Console.WriteLine("-------------------------");
            }
            else Console.WriteLine("다시 확인부탁드립니다.");
        }

        public void allData()
        {
            if (Name != null)
            { 
            Console.WriteLine("-------------------------");
            Console.WriteLine($"이름 입력: {Name}");
            Console.WriteLine($"전화 입력: {Tel}");
            Console.WriteLine($"주소 입력: {Addr}");
            Console.WriteLine("-------------------------");
            }
        }

        public string menu()
        {
            Console.WriteLine("0. 주소 입력");
            Console.WriteLine("1. 주소 검색");
            Console.WriteLine("2. 주소 수정");
            Console.WriteLine("3. 주소 삭제");
            Console.WriteLine("4. 주소 전체 출력");
            Console.WriteLine("5. 프로그램종료");
            Console.Write("메뉴를 선택하세요 >>>");
            string menu = Console.ReadLine();
            return menu;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int i = 0;
            int a = 0;
            Information[] Info;
            Info = new Information[10];

            for (int k = 0; k < 10; k++)
            {
                Info[k] = new Information();
            }
            Information Menu = new Information();
            while (true)
            {
                string menu = Menu.menu();
                if (menu == "5") break;
                
                switch (menu)
                {
                    case "0":
                        Info[i].inputData();
                        i++;
                        break;

                    case "1":
                        Console.WriteLine("검색할 사용자의 이름을 적어주세요: ");
                        string selName = Console.ReadLine();
                        try
                        {
                            for (a = 0; Info[a].Name != selName; a++) ;
                            Info[a].selectData(selName);
                        }
                        catch
                        {
                            Console.WriteLine("없는 이름입니다.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("수정할 사용자의 이름을 적어주세요: ");
                        string modName = Console.ReadLine();
                        try
                        {
                            for (a = 0; Info[a].Name != modName; a++) ;
                            Info[a].modData(modName);
                        }
                        catch
                        {
                            Console.WriteLine("없는 이름입니다.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("삭제할 사용자의 이름을 적어주세요: ");
                        string delName = Console.ReadLine();
                        try
                        {
                            for (a = 0; Info[a].Name != delName; a++) ;
                            Info[a].deletData(delName);
                        }
                        catch
                        {
                            Console.WriteLine("없는 이름입니다.");
                        }
                        break;

                    case "4":
                        for (int j = 0; j < 10; j++)
                        {
                            Info[j].allData();
                        }
                        break;

                    default:
                        Console.WriteLine("1~5 중에 하나를 선택하세요");

                        break;
                }

            }

        }
    }
}
