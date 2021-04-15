using System;

namespace HW4_3
{
    class Program
    {
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца"); 
            int number = Convert.ToInt32(Console.ReadLine());
            string message = SeasonConvert(number);  
            while ((message == "")) 
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12 повторите попытку");
                number = Convert.ToInt32(Console.ReadLine());
                message = SeasonConvert(number);
            }

            if (message == "Winter") //проверка на время года 
            {
                Console.WriteLine("На улице зима"); 
            }
            else if (message == "Spring")
            {
                Console.WriteLine("На улице весна");
            }
            else if (message == "Summer")
            {
                Console.WriteLine("На улице лето");
            }
            else if (message == "Autumn")
            {
                Console.WriteLine("На улице Осень");
            }
        }
        static string SeasonConvert(int number)
        {
            Season op;
            string msg = string.Empty; //создаем пустую строку чтобы записать в нее ответ
            switch (number) //Число которое ввел пользователь
            {
                case 12:
                case 1:
                case 2:
                    msg += op = Season.Winter; 
                    break;
                case 3:
                case 4:
                case 5:
                    msg += op = Season.Spring; // Если от 3 до 5 - весна
                    break;
                case 6:
                case 7:
                case 8:
                    msg += op = Season.Summer; //Если от 6 до 8 - лето
                    break;
                case 9:
                case 10:
                case 11:
                    msg += op = Season.Autumn; //Если от 9 до 11 - весна
                    break;
                default:

                    break;
            }
            return (msg);
        }
    }
}
