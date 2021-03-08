using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTestApp
{
    class TestClass
    {
        public static int number;
        public float fnum;

        public float ProcSomething()
        {
            Console.WriteLine($"{number} != {fnum} ABC");
            return 1.0f;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            TestClass.number = 10;

            TestClass aCls = new TestClass();
            aCls.fnum = 3.25f;

            TestClass bCls = new TestClass();
            bCls.fnum = 4.87f;

            aCls.ProcSomething();
            bCls.ProcSomething();
        }
    }
}
