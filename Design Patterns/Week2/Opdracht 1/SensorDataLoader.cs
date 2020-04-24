using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class SensorDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("Extracting sensor data");
        }

        public override void Transform()
        {
            Console.WriteLine("Transforming sensor data");
        }

        public override void Load()
        {
            Console.WriteLine("Loading sensor data");
        }
    }
}
