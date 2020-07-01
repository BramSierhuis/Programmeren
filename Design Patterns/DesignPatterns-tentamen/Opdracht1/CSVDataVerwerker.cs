using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    public class CSVDataVerwerker : DataVerwerker
    {
        public override void LeesData()
        {
            Console.WriteLine("Lees data uit CSV-bestand...");
        }

        public override void DoorloopData()
        {
            Console.WriteLine("Doorloop data uit CSV-bestand...");
        }
    }
}
