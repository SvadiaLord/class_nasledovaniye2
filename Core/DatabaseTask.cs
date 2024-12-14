using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye2.Core
{
    internal class DatabaseTask : A_Task
    {
        public override void Execute() => Console.WriteLine("Провожу экзекуцию датабазы...");
    }
}
