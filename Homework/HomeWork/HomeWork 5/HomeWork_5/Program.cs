using System;
using System.IO;

namespace HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
          //TextInFile();
          //TimeInText();
          //TextInBin();
            Employee[] persArray = new Employee[5];
            persArray[0] = new Employee("Ivanov Ivan", "Engineer", "iivan@mailbox.com", "89231231212", 30000, 42);
            persArray[1] = new Employee("Petrov Alexey", "Director", "palexey@mailbox.com", "89244564052", 300000, 25);
            persArray[2] = new Employee("Sidorov Boris", "Administrator", "sboris@mailbox.com", "89221235220", 50000, 30);
            persArray[3] = new Employee("Alexeev Alexey", "Programmer", "aalexey@mailbox.com", "89244685452", 150000, 35);
            persArray[4] = new Employee("Borisov Nikolai", "Manager", "bnikoay@mailbox.com", "89261551520", 45000, 42);
            for (int i = 0; i <persArray.Length; i++)
            {
                if (persArray[i].age > 40)
                {
                    persArray[i].Print();
                }
               
            }
        }
        static void TextInFile() //HW5_1
        {
            Console.WriteLine("Введите название файла");
            string FileName = Console.ReadLine();
            while (File.Exists(FileName + ".txt") || string.IsNullOrEmpty(FileName) || string.IsNullOrWhiteSpace(FileName))
            {
                if (File.Exists(FileName + ".txt"))
                {
                    Console.WriteLine($"Файл с именем {FileName + ".txt"} Сущеуствует введите другое имя");
                    FileName = Console.ReadLine();
                }
                if (string.IsNullOrEmpty(FileName) || string.IsNullOrWhiteSpace(FileName))
                {
                    Console.WriteLine("Вы ввели пустое имя файла");
                    FileName = Console.ReadLine();
                }
            }
            Console.WriteLine("Введите Текст");
            string Text = Console.ReadLine();
            File.WriteAllText(FileName + ".txt", Text);
            Console.WriteLine($"В файле {FileName} имеется следующий текст {Text}");
        }

        static void TimeInText() //HW5_2
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            File.WriteAllText("startup.Txt", time);
            Console.WriteLine($"В файле startup.txt записано следующее время {time}");
        }
        static void TextInBin() //HW5_3
        {
            Console.WriteLine("Введите название файла");
            string FileName = Console.ReadLine();
           
            while (File.Exists(FileName + ".bin") || string.IsNullOrEmpty(FileName) || string.IsNullOrWhiteSpace(FileName))
            {
                if (File.Exists(FileName + ".bin"))
                {
                    Console.WriteLine($"Файл с именем {FileName + ".bin"} Сущеуствует введите другое имя");
                    FileName = Console.ReadLine();
                }
                if (string.IsNullOrEmpty(FileName) || string.IsNullOrWhiteSpace(FileName))
                {
                    Console.WriteLine("Вы ввели пустое имя файла");
                    FileName = Console.ReadLine();
                }
            }
            Console.WriteLine("Введите цифры от 0 до 255");
            string text = Console.ReadLine();
            File.WriteAllText(FileName + ".bin", text);
        }
    }
}
