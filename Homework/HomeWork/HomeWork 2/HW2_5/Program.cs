using System;

namespace HW2_5
{
    class Program
    {
        static void Main(string[] args)
        {

            double max; 
            double min; 

            Console.WriteLine(@"Данная программа позволит вам высчитать среднесуточную температуру за сутки а также определит тип погоды 
для продолжения введите минимальную температуру за сутки и нажмите Enter");  

            while (double.TryParse(Console.ReadLine(), out min) == false)
            /* вводим переменную, и проверяем на ввод числа 
            или пустого ввода в противном случае просим повторно ввести данные*/
            {
                Console.WriteLine("Введено неккоректное значение или пустой ввод пожалуйста повторите ввод");
            }

            Console.WriteLine("Введите максимальную температуру за сутки и нажмите Enter"); //просим ввести макс - ую темп - ру
            while (double.TryParse(Console.ReadLine(), out max) == false || max <= min)
            /*вводим переменную, и проверяем на ввод числа или пустого ввода а также чтобы макс-ая темп-ра не была меньше мин-ой 
            в противном случае просим повторно ввести данные
            */
            {
                Console.WriteLine("Некоректный ввод, или значение меньше минимальной температуры, повторите ввод");
            }
            Console.WriteLine("Введите номер текущего месяца");
            int month = Convert.ToInt32(Console.ReadLine());

            double res = (min + max) / 2;  
            if ((month <= 3 || month == 12) && res > 0)
            {
                Console.WriteLine("Дождливая зима");
            }
            else
            {
                Console.WriteLine("Погода хорошая");
            }
            Console.WriteLine("Среднесуточная температура = " + res + "c"); 
            Console.ReadKey();
        }
    }
}
