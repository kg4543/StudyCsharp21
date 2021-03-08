using System;

namespace InheritTestApp
{
    class Parent
    {
        protected string Name;

        public Parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Parent() 생성자");
        }

 /*       ~Parent()
        {
            Console.WriteLine($"{this.Name}.Parent() 소멸자");
        }*/

        public void ParentMethod()
        {
            Console.WriteLine($"{this.Name}.ParentMethod()");
        }
    }

    class Child : Parent
    {
        public string Collor;
        public Child(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Child() 생성자");
        }

/*        ~Child() 
        {
            Console.WriteLine($"{this.Name}.Child() 소멸자");
        }*/

        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.ChildMethod() 실행");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent("부모");
            p.ParentMethod(); // 부모클래스 method 실행
            Child c = new Child("자식");
            c.Collor = "베이지";
            c.ParentMethod(); //보모 method 실행가능
            c.ChildMethod(); // 자식클래스 method 실행
        }
    }
}
