using System;

namespace OverrideTestApp
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("ArmorSuite 초기화");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("IronMan parts 장착");
            Console.WriteLine("IronMan 1기 완료");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            Console.WriteLine("Warmachine parts 장착");
            Console.WriteLine("Warmachine 1기 완료");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArmorSuite 생산");
            ArmorSuite suite = new ArmorSuite();
            //suite.Initialize();

            Console.WriteLine("Ironman version update");
            IronMan man = new IronMan();
            man.Initialize();

            Console.WriteLine("WarMachine version update");
            WarMachine machine = new WarMachine();
            machine.Initialize();
        }
    }
}
