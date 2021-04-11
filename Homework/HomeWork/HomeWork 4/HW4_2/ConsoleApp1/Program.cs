using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа с пробелом или с разделителем _ \n ВНИМАНИЕ ВВОДИТЬ МОЖНО ТОЛЬКО ОДИН ПРОБЕЛ ИЛИ РАЗДЕЛИТЕЛЬ _ НА ОДНО ЧИСЛО ");
            int res = Conv(Console.ReadLine());


            Console.WriteLine("Результат сложения вашего числа = " + res); 
        }
        static int Conv(string str)
        {

            string[] words = str.Split(new char[] { ' ', '_', ' ' }); /* после принятия создаем и в нем используя метод split
                                                                    убираем все пробелы или знаки нижнего подчеркивания*/
            int[] a = Array.ConvertAll(words, Convert.ToInt32); /* создав еще один массив перекидываем туда данные из массива words 
                                                                 * и конвертируем в Int*/
            int c = 0; //создаем переменную с куда запишем результат
            for (int i = 0; i < a.Length; i++) // создаем цикл для сложения значений масиива
            {
                c = c + a[i];
            }
            return (c); //передаем результат
        }
    }
}
