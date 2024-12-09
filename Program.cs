using classnasledovaniye2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye2
{
    internal class Program
    {
        static public Account account = new Account("Вова", "Путин", 0);
        static void Main(string[] args)
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.Name = "Алексей Панфилов";
            fullTimeEmployee.Salary = 1820;
            fullTimeEmployee.DisplayInfo();

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.Name = "Сергей Родиков";
            partTimeEmployee.Salary = 1820;
            partTimeEmployee.DisplayInfo();


            Console.WriteLine(account.Deposit(1820, 1.5, 365));
            account.Withdraw();

            Console.ReadKey();

            
        }
    }
}
