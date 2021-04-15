using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_5
{
    class Employee
    {
        string name;
        string Posiition;
        string email;
        string PhoneNumber;
        int Salary;
        public int age { get; }
        public Employee(string name, string position, string email, string PhoneNumber, int salary, int age)
        {
            this.name = name;
            this.Posiition = position;
            this.email = email;
            this.PhoneNumber = PhoneNumber;
            this.Salary = salary;
            this.age = age;

        }
        public void Print()
        {
            Console.WriteLine($"Имя: {name} Должность: {Posiition} email: {email} \nномер телефона: {PhoneNumber} Зарплата: {Salary} Возраст: {age}");
        }
    }
}
