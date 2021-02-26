using System;

namespace _2DegreeArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { {1,2,3 },{4,5,6 } };
            /*arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;
            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;*/

            for (int i = 0; i < arr.GetLength(0); i++) // 행
            {
                for (int j = 0; j < arr.GetLength(1); j++) // 열
                {
                    Console.Write($"[{i},{j}] :{arr[i,j]} \t");
                }
                Console.WriteLine("");
            }
        }
    }
}
