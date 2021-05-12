using System;
using System.Text.RegularExpressions;

namespace HomeWork_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // TaskManager taskManager = new TaskManager();
            // taskManager.ProcessKill();
            Exception();
        }
        static void Exception()
        {
            int a = 0;
            String[,] correct = {
                    {"1", "2", "3", "4"},
                    {"1", "2", "3", "4"},
                    {"1", "2", "3", "4"},
                    {"1", "2", "3", "4"} };
            String[,] incorrect = {
                    {"1", "2", "3", "4"},
                    {"1", "2", "3", "4"},
                    {"1", "2", "3", "4"},
                    {"1", "2", "b", "4"},
             {"1", "2", "b", "4"}};

            try
            {
                a = Array(correct);
                Console.WriteLine($"Сумма всех элементов массива = {a}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");

            }

        }
        static int Array(string[,] array)
        {
            int a = 0;
            int[,] arr = new int[4, 4];
            if (array.GetLength(0) != 4 | array.GetLength(1) != 4)
            {
                throw new Exception("Размер меньше положенного");
            }
            else
            {
                Console.WriteLine("Все нормально");
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (Regex.IsMatch(array[i, j], @"\d") == false)
                    {
                        throw new Exception($"В строке {i},{j} расположен символ не являющийся числом");
                    }
                    else
                    {
                        arr[i, j] = Convert.ToInt32(array[i, j]);
                        a = a + arr[i, j];
                    }
                }
            }
            return a;
        }

    }
}
