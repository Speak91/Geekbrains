using System;

namespace HW2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число и выясним четное оно или нет"); // Просим пользователя ввести число 
            double number;
            while (double.TryParse(Console.ReadLine(), out number) == false) // проверяем введено ли число если нет просим ввести повторно
            {
                Console.WriteLine("введено не число, введите число");
            }
            double Remainder = Math.IEEERemainder(number, 2); // Проверяем есть ли остаток
            if (Remainder == 0) //если остатка нет значит оно четное о чем и сообщаем пользователю 
            {
                Console.WriteLine("Четное");
            }
            else { Console.WriteLine("Нечетное"); }

            Console.ReadKey();
        }
    }
}
