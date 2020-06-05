using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class LowBudgetShop : ComputerShop
    {
        public override IProcessor CreateProcessor()
        {
            return new CheapProcessor();
        }

        public override IMonitor CreateMonitor()
        {
            return new CheapMonitor();
        }

        public override IHardDisk CreateHardDisk()
        {
            return new CheapHardDisk();
        }
    }
}
