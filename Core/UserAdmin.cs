using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye2.Core
{
    internal class UserAdmin : A_User
    {
        public void ManageUsers() => Console.WriteLine($"{Username} имаджиниирует бурную деятельность.");
    }
}
