using System;

namespace Chap07App
{
    class ObjectTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("고양이 객체 만들기");

            /*            Cat cat1 = new Cat();
                        cat1.Name = "키티";
                        cat1.Color = "하얀";
                        cat1.Meow();

                        Cat cat2 = new Cat();
                        cat2.Name = "네로";
                        cat2.Color = "검은";
                        cat2.Meow();

                        Cat catdog = new Cat(name: "호랑이", color: "주황색", gender: "수컷");*/

            Cat yomi = new Cat("요미","하얀","암컷");
            yomi.Meow();
        }
    }
    class Cat
    {
        public Cat() { }
        public string Name;
        public string Color;
        public string Gender;

        public Cat(string Name) 
        {
            this.Name = Name;
        }

        public Cat(string Name,string Color) : this(Name)
        {
            this.Color = Color;
        }

        public Cat(string Name, string Color, string gender) : this(Name, Color) //재사용률 증가
        {
            Gender = gender;
        }

    public void Meow()
        {
            Console.WriteLine($"{Color} 고양이 '{Name}' ({Gender}): 야옹!");
        }
    }
}
