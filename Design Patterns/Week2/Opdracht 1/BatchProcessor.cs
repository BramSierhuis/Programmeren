using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class BatchProcessor
    {
        private List<BigDataLoader> dataLoaders = new List<BigDataLoader>();

        public void AddLoader(BigDataLoader dataLoader)
        {
            Console.WriteLine("Adding BigDataLoader");

            dataLoaders.Add(dataLoader);
        }

        public void ProcessAll()
        {
            Console.WriteLine("Processing all BigDataLoaders");
            Console.WriteLine();

            foreach (BigDataLoader dataLoader in dataLoaders)
            {
                dataLoader.StartETL();
                Console.WriteLine();
            }
        }
    }
}
