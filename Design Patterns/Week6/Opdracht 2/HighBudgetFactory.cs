using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_2
{
    public class HighBudgetFactory : ComputerFactory
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
