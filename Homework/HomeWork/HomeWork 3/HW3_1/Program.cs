using System;

namespace HW3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int [5,6];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        array[i,j] = 1;
                    }
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
