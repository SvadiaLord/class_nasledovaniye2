using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye2.Core
{
    internal class Account
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Balance { get; set; }
        
        public Account(string name, string surname, double balance)
        {
            Name = name;
            Surname = surname;
            Balance = balance;
        }
        public virtual double Deposit(int denga, double procent, int dey)
        {
            double result = denga * procent * dey / 365;
            Balance += result;
            return result;
        }

        public virtual void Withdraw()
        {
            Console.WriteLine($"Имя аккаунsта {Name}");
            Console.WriteLine($"Фамилия аккаунта {Surname}");
            Console.WriteLine($"Баланс аккаунта {Balance}");
        }
    }
}
