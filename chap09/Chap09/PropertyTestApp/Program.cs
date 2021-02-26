using System;

namespace PropertyTestApp
{
    // 생일정보 클래스
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;
        public string usage;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public DateTime Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public DateTime GetBirthday()
        {
            return this.birthday;
        }

        public void SetBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("일반 Get/Set 메소드 사용");
            BirthdayInfo info = new BirthdayInfo();
            info.SetName("홍길동");
            info.SetBirthday(new DateTime(1990, 1, 8));

            Console.WriteLine($"이름 : {info.GetName()}");
            Console.WriteLine($"이름 : {info.GetBirthday()}");

            Console.WriteLine("프로퍼티 사용");
            BirthdayInfo info2 = new BirthdayInfo();
            info2.Name = "박수홍";
            info2.Birthday = new DateTime(1993, 3, 10);

            info.usage = "사용";


            Console.WriteLine($"이름 : {info2.Name}");
            Console.WriteLine($"이름 : {info2.Birthday}");

        }
    }
}
