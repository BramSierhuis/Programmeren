using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_2
{
    public abstract class ComputerFactory
    {
        public void AssembleMachine()
        {
            //Natuurlijk kan ik de componenten ook opslaan, maar dat is voor deze implementatie niet nodig
            CreateProcessor().PerformOperation();
            CreateMonitor().Display();
            CreateHardDisk().StoreData();
        }

        public abstract IProcessor CreateProcessor();
        public abstract IMonitor CreateMonitor();
        public abstract IHardDisk CreateHardDisk();
    }
}
