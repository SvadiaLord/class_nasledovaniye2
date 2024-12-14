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

            Cat cat = new Cat();
            Dog dog = new Dog();
            Console.WriteLine("Кот говорит: "+ cat.Speak());
            Console.WriteLine("Собака говорит: " + dog.Speak());

            EmailTask emailTask = new EmailTask();
            DatabaseTask databaseTask = new DatabaseTask();
            emailTask.Execute();
            databaseTask.Execute();

            UserAdmin userAdmin = new UserAdmin();
            RegularUser admin = new RegularUser();
            userAdmin.Login();
            admin.Login();

            Circle circle = new Circle();
            Square square = new Square();
            Console.WriteLine(circle.GetInfo());
            Console.WriteLine(square.GetInfo());

            House house = new House();
            ApartmentBuilding apartmentBuilding = new ApartmentBuilding();
            OfficeBuilding officeBuilding = new OfficeBuilding();


            Console.ReadKey();

            
        }
    }
}
