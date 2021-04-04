using System;

namespace HW2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "ООО Петер-Сервис Спецтехнологии"; //наименование магазина
            long inn = 123456789; //инн магазина
            int index = 115280; // почтовый индекс магазина
            string tel = "8 800 550-99-11"; //номер телефона магазина
            Random rnd = new Random(); //создание обьекта для генерации случайного числа
            int cn = rnd.Next(10000, 40000); //генерируем случайное число для чека
            ulong fiscalnumb = 6464645654645; //Фискальный номер
            ulong rnumber = 4645645988444;   //Рег номер ККТ
            ulong znumber = 89849484;      //Заводской номер ККТ
            ulong fdnumber = 49849856;    //порядковый номер фискального документа
            ulong fpdnumber = 12626124;  //Фискальный признак документа
            int price = 150; //Цена за товар
            int cucumber; //Переменная для количества приобретаемыx огурцов
            int tomato; // Переменная для количества приобретаемыx помидоров

            Console.WriteLine("Введите сколько килограм огурцов вам надо"); //спрашиваем у пользователя количество приобретаемыx огурцов
            cucumber = Convert.ToInt32(Console.ReadLine());
            int cucsum = price * cucumber; //сумма за огурцы
            Console.WriteLine("Введите сколько килограм Помидоров вам надо"); //спрашиваем у пользователя количество приобретаемыx помидоров
            tomato = Convert.ToInt32(Console.ReadLine());
            int cuctom = price * tomato; //сумма за помидоры
            int sum = (price * cucumber) + (price * tomato); //Считаем общую сумму
            Console.WriteLine("\t\t\t\tКассовый чек" + "\n\tПриход" + "\n\t" + name
               + "\n\tИНН " + inn + "\n\t" + index + "г. Москва. ул. Ленинская Слобода. 19" + "\n\t" + tel + "\n\t" + DateTime.Now +
                 "\t\t\t\t\tЧек №" + cn + "\n\tКассир: Иванова И.И" + "\t\t\t\t\tСмена № 00123" + "\n\tФН" + "\t\t\t\t\t\t\t" +
                 fiscalnumb + "\n\tРН ККТ\t\t\t\t\t\t\t" + rnumber + "\n\tЗН ККТ\t\t\t\t\t\t\t     " + znumber + "\n\tФД\t\t\t\t\t\t\t     "
                 + fdnumber + "\n\tФПД\t\t\t\t\t\t\t     " + fpdnumber + "\n\t*********************************************************************" +
                 "\n\tПокупка огурцов" + "\n\t\t\t\t\t\t" + price + " X " + cucumber + "\t\t\t=" + cucsum +
                 "\n\tПокупка помидоров" + "\n\t\t\t\t\t\t" + price + " X " + tomato + "\t\t\t=" + cuctom + "\n\t" +
                 "\n\t*********************************************************************" +
                "\n\tИТОГ" + "\t\t\t\t\t\t\t     = " + sum + "Руб"); //формируем чек
            Console.ReadLine();
        }
    }
}
