using System;

namespace HW2_6
{
    class Program
    {

        [Flags]
        enum DaysOfWeek
        {
            Monday = 0b_0000001, //понедельник 
            Tuesday = 0b_0000010, //вторник
            Wednesday = 0b_0000100, //Среда
            Thursday = 0b_0001000, //Четверг
            Friday = 0b_0010000, //Пятница
            Saturday = 0b_0100000, //Суббота
            Sunday = 0b_1000000 //Воскресенье
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите № Офиса с 1 по 3");

            string chooff = Console.ReadLine();
            switch (chooff)
            {
                case "1":
                    DaysOfWeek officeone = (DaysOfWeek)0b_0011111;
                    Console.WriteLine("Офис № " + chooff + " работает в " + officeone);
                    break;
                case "2":
                    DaysOfWeek officetwo = (DaysOfWeek)0b_1010101;
                    Console.WriteLine("Офис № " + chooff + " работает в " + officetwo);
                    break;
                case "3":
                    DaysOfWeek officethree = (DaysOfWeek)0b_1111110;
                    Console.WriteLine("Офис № " + chooff + " работает в " + officethree);
                    break;
                default:
                    Console.WriteLine("Такого офиса нет");
                    break;
            }


            Console.ReadKey();
        }
    }
}
