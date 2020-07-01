using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    public class DatabaseDataVerwerker : DataVerwerker
    {
        public override void LeesData()
        {
            Console.WriteLine("Lees data uit database...");
        }

        public override void DoorloopData()
        {
            Console.WriteLine("Doorloop data uit database...");
        }
    }
}
