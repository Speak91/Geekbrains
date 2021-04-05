using System;

namespace HW3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра морской бой");
            char[,] array = new char[10, 10]  {
                {'O','X','O','O','O','O','O','O','X','O'},
                {'O','O','O','O','O','X','X','O','X','O'},
                {'O','O','O','O','O','O','O','O','X','O'},
                {'O','X','X','X','X','O','O','O','O','O'},
                {'O','O','O','O','O','O','O','O','O','O'},
                {'O','O','O','O','X','O','O','O','O','O'},
                {'O','X','X','O','O','O','O','O','O','X'},
                {'O','O','O','O','O','O','O','O','O','O'},
                {'O','O','O','X','O','X','X','X','O','O'},
                {'O','O','O','X','O','O','O','O','O','O'}};
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
