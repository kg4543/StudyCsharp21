using System;
using System.Text;

namespace StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello World!");
            // sb[5] = 'N'; 
            sb.Append("My name is Kim.\n");
            sb.Append("I buy the book");
            sb.Append("payed 30,000 won.");
            sb.Insert(6, "new ");
            sb.Replace("30,000 won", "10만원");

            Console.WriteLine(sb);
        }
    }
}
