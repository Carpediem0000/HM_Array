using System;

namespace HM_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int row = arr.GetUpperBound(0) + 1;
            int col = arr.Length / row;

            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sum += arr[i, j];
                }
            }


            int[,] arr1 =
            {
                { 1, 2, 3 },
                { 5, 6, 7 },
                { 9, 10, 11 }
            };
            int[,] res = new int[col, row];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    res[j, i] = arr1[i, j];
                }
            }
        }
    }
}
