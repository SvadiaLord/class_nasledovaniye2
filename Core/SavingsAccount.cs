using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye2.Core
{
    internal class SavingsAccount : Account
    {
        public SavingsAccount() : base(Program.account.Name, Program.account.Surname, Program.account.Balance)
        {
            
        }

        public virtual double CalculateInterest(int denga, double procent, int dey)
        {
            double result = denga * procent * dey / 365;
            Program.account.Balance += result;
            return result;
            
        }
    }
}
