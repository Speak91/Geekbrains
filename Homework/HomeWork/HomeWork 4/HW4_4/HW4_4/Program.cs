using System;

namespace HW4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления числа Фибоначчи");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = Fibo(8);
            Console.Write($"Первые {number} чисел Фибоначчи ");
            for (int i = 0; i < number; i++)
            {
                var separator = i + 1 == number ? string.Empty : ", ";
                Console.Write($"{Fibo(i)}{separator}");

            }
        }
        static int Fibo(int number)
        {
            int b;
            if (number == 1 ||number == 0)
            {
                return number;
            }

            else
            {
                return b = Fibo(number - 1) + Fibo(number - 2);
            }
        }
    }
}
