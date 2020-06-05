using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_2
{
    public class CheapProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Calculating on a single core toaster");
        }
    }
}
