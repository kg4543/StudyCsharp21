using System;
using System.Collections.Generic;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 실무에서 많이 쓰는 컬렉션2
            Dictionary<int, string> pairs = new Dictionary<int, string>()
            {
                {1, "one"},
                {2, "two"},
                {3, "three"},
                /*{4, "four"},
                {5, "five"},*/
            };
            /*pairs[1] = "One";
            pairs[2] = "Two";
            pairs[3] = "Three";*/
            pairs[4] = "Four";
            pairs[5] = "Five";
            foreach (var item in pairs)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Dictionary<string, string> pairs2 = new Dictionary<string, string>();
            pairs2["일"] = "One";
            pairs2["이"] = "Two";
            pairs2["삼"] = "Three";
            pairs2["사"] = "Four";
            pairs2["오"] = "Five";
            foreach (var item in pairs)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
