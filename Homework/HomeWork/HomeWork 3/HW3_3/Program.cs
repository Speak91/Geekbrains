using System;

namespace HW3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово"); 
            string s = Console.ReadLine();
            char[] sReverse = s.ToCharArray(); 
            Array.Reverse(sReverse); 
            string output = new string(sReverse); 
            Console.WriteLine("В перевернутом виде выглядит вот так " + output); 

        }
    }
}
