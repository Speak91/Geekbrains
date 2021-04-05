using System;

namespace HW3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[2, 5]{
                {"Вася","Тима","Дима","Коля", "Дима"},
                {"+79141234565","+79246569889","+79244567895","+4112365698", "+74951261616"} };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("|{0,-13}|", array[i, j]);
                }
                Console.WriteLine();
            }
       
        }
    }
}
