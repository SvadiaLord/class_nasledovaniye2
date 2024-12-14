using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye2.Core
{
    internal class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee() { }
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual double CalculateBonus()
        {
            return 0;
        }
        public virtual void DisplayInfo()
        {
            double bonus = CalculateBonus();
            Console.WriteLine($"Имя: {Name}, Зарплата: {Salary}, с бонусом к зарплате: {bonus}.");
        }
    }
}

