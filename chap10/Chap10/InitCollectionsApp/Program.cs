using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitCollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };
            ArrayList list = new ArrayList(arr);
            foreach (var item in list)
            {
                Console.WriteLine($"Arraylist : {item}");
            }

            Stack stack = new Stack(arr);
            foreach (var item in stack)
            {
                Console.WriteLine($"Stack : {item}");
            }

            ArrayList list2 = new ArrayList() { 10, 20, 30, 40};
            foreach (var item in list2)
            {
                Console.WriteLine($"ArrayList2 : {item}");
            }
        }
    }
}
