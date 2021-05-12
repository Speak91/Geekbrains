using System;
using MyClassLibrary;
namespace Test_My_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            MyClassLibrary.Class1.Hello(Console.ReadLine());
        }
    }
}
