using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashTable 예제");
            Hashtable ht = new Hashtable();
            ht["일"] = "one";
            ht["이"] = "two";
            ht["삼"] = "three";
            ht["사"] = "four";

            Console.WriteLine(ht["일"]); // one
            Console.WriteLine(ht["이"]); // two
            Console.WriteLine(ht["삼"]); // three
            Console.WriteLine(ht["사"]); //four

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            int[] arr = { 123, 456, 789 };
            ArrayList list = new ArrayList(arr);
            ArrayList list2 = new ArrayList(new int[] { 123, 456, 789 });
            ArrayList list3 = new ArrayList { 123, 456, 789 };

        }
    }
}
