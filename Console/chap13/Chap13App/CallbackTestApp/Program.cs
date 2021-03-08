using System;

namespace CallbackTestApp
{
    delegate int Compare(int a, int b); //a,b 비교 대리자
    class Program
    {
        //오름차순 a > b 이면 1 반환 , a = b  0 반환, a < b 이면 -1 반환
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1; //a,b 순서바꿈
            else if (a == b) return 0;
            else return -1;
        }
        //내림차순 a < b 이면 1 반환 , a = b  0 반환, a > b 이면 -1 반환
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1; //a,b 순서바꿈
            else if (a == b) return 0;
            else return -1;
        }

        static void BubbleSort(int[] DataSet, Compare comparer)
        {
            int temp = 0;
            for (int i = 0; i < DataSet.Length; i++)
            {
                for (int j = 0; j < DataSet.Length-(i+1); j++)
                {
                    //비교하여 값 위치 변경
                    if(comparer(DataSet[j], DataSet[j+1])>0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 8, 4, 2, 1, 10 };
            Console.WriteLine("Sorting.....");
            BubbleSort(array, new Compare(AscendCompare)); //오름차순 정렬
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("Sorting.....");
            BubbleSort(array, new Compare(DescendCompare)); //내림차순 정렬
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
