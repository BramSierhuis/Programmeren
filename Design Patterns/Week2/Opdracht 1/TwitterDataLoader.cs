using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class TwitterDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("Extracting twitter data");
        }

        public override void Transform()
        {
            Console.WriteLine("Transforming twitter data");
        }

        public override void Load()
        {
            Console.WriteLine("Loading twitter data");
        }
    }
}
