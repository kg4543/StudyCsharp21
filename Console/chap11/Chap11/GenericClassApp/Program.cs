using System;

namespace GenericClassApp
{
    class Program
    {
        class Array_Generic<T>
        {
            private T[] array;

            public Array_Generic()
            {
                array = new T[10];
            }

            public T GetElement(int index) { return array[index]; }
            public int Length { get { return array.Length; } }
        }
        static void Main(string[] args)
        {
            Array_Generic<int> array = new Array_Generic<int>();
            Array_Generic<string> starr = new Array_Generic<string>();

        }
    }
}
