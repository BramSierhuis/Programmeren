using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    public abstract class DataVerwerker
    {
        public void VerwerkData()
        {
            LeesData();
            DoorloopData();
            SchrijfData();
        }

        public abstract void LeesData();

        public abstract void DoorloopData();

        public void SchrijfData()
        {
            Console.WriteLine("Schrijf data naar CSV...");
        }
    }
}
