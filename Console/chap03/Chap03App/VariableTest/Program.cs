using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 30, v2 = 40;
            int result = v1 + v2;
            Console.WriteLine("결과는" + result);

            //byte
            sbyte sbMinval = sbyte.MinValue;
            sbyte sbMaxval = sbyte.MaxValue;
            Console.WriteLine($"sbyte 최소, 최대값은 {sbMinval}, {sbMaxval} 입니다.");
            byte bMinval = byte.MinValue, bMaxval = byte.MaxValue;
            Console.WriteLine($"byte 최소, 최대값은 {bMinval}, {bMaxval} 입니다.");
            //short
            short shMinval = short.MinValue, shMaxval = short.MaxValue;
            Console.WriteLine($"short 최소, 최대값은 {shMinval}, {shMaxval} 입니다.");
            ushort usMinval = ushort.MinValue, usMaxval = ushort.MaxValue;
            Console.WriteLine($"ushort 최소, 최대값은 {usMinval}, {usMaxval} 입니다.");
            //int
            int inMinval = int.MinValue, inMaxval = int.MaxValue;
            Console.WriteLine($"int 최소, 최대값은 {inMinval}, {inMaxval} 입니다.");
            uint uiMinval = uint.MinValue, uiMaxval = uint.MaxValue;
            Console.WriteLine($"ushort 최소, 최대값은 {uiMinval}, {uiMaxval} 입니다.");
            //long
            long lnMinval = long.MinValue, lnMaxval = long.MaxValue;
            Console.WriteLine($"long 최소, 최대값은 {lnMinval}, {lnMaxval} 입니다.");
            ulong ulMinval = ulong.MinValue, ulMaxval = ulong.MaxValue;
            Console.WriteLine($"ushort 최소, 최대값은 {ulMinval}, {ulMaxval} 입니다.");
            //float
            float fMinval = float.MinValue, fMaxval = float.MaxValue;
            Console.WriteLine($"long 최소, 최대값은 {fMinval}, {fMaxval} 입니다.");
            //double
            double dMinval = double.MinValue, dMaxval = double.MaxValue;
            Console.WriteLine($"ushort 최소, 최대값은 {dMinval}, {dMaxval} 입니다.");
            //decimal
            decimal dcMinval = decimal.MinValue, dcMaxval = decimal.MaxValue;
            Console.WriteLine($"long 최소, 최대값은 {dcMinval}, {dcMaxval} 입니다.");
        }
    }
}
