using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_2
{
    public class ExpensiveMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Displaying in 4k");
        }
    }
}
