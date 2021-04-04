using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет введи имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name} сегодня {DateTime.Now.Date.ToString("d")}");
        }
    }
}
