using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_2
{
    public class ExpensiveHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Storing data on a SSD");
        }
    }
}
