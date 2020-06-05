using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class CheapHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Storing data on a harddisk");
        }
    }
}
