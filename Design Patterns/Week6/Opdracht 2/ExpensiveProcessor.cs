﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_2
{
    public class ExpensiveProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Calculating using 8 cores");
        }
    }
}
