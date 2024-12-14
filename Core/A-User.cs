using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye2.Core
{
    public class A_User
    {
        public string Username { get; set; }

        public virtual void Login() => Console.WriteLine($"{Username} Вошел. . .");
    }
}
