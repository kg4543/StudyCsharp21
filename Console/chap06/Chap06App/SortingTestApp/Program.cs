using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 47, y = 5;

            Console.WriteLine($"Before Swap {x},{y}");

            Program.Swap(ref x,ref y); // 정렬 기반

            Console.WriteLine($"After Swap {x},{y}");
        }

        private static void Swap(ref int p1, ref int p2)
        {
            int temp = p1; // temp = 47
            p1 = p2; // p1 = 5 , p2 = 5
            p2 = temp; // p2 = 47
        }
    }
}
