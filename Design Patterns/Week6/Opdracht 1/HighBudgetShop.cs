using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class HighBudgetShop : ComputerShop
    {
        public override IProcessor CreateProcessor()
        {
            return new ExpensiveProcessor();
        }

        public override IMonitor CreateMonitor()
        {
            return new ExpensiveMonitor();
        }

        public override IHardDisk CreateHardDisk()
        {
            return new ExpensiveHardDisk();
        }
    }
}
