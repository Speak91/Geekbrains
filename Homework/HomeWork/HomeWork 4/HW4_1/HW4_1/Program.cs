using System;

namespace HW4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = GetFullName("Иванов ", " Иван ", " Иванович");
            string message2 = GetFullName("Петров ", " Петр ", " Петрович");
            string message3 = GetFullName("Сидоров ", " Иван ", " Иванович");
            string message4 = GetFullName("Васильев ", " Василий ", " Иванович");

            Console.WriteLine(message + "\n" + message2 + "\n" + message3 + "\n" + message4);
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string msg = firstName + lastName + patronymic;

            return (msg);
        }
    }
}
