using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye2.Core
{
    internal class EmailTask : A_Task
    {
        public override void Execute() => Console.WriteLine("Отправляю тебе письмо пидор...");
    }
}
