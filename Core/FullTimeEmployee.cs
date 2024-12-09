using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye2.Core
{
    internal class FullTimeEmployee : Employee
    {
        public void FullTime()
        {
            Console.WriteLine($"Сотрудник {Name}. Зарплата {Salary}");
        }
        public override double CalculateBonus()
        {
            return Salary * 0.5;
        }
    }
}
