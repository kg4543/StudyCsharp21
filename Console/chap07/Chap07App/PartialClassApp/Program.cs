using System;

namespace PartialClassApp
{
    partial class Myclass
    {
        public void Method3() { Console.WriteLine("Method3"); }
        public void Method4() { Console.WriteLine("Method4"); }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass _class = new Myclass();
            _class.Method1();
            _class.Method2();
            _class.Method3();
            _class.Method4();
        }
    }
}
