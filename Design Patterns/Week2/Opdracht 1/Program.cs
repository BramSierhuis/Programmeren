using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }

        void Start()
        {
            BatchProcessor processor = new BatchProcessor();

            SensorDataLoader sensorDataLoader = new SensorDataLoader();
            TwitterDataLoader twitterDataLoader = new TwitterDataLoader();
            CallDataLoader callDataLoader = new CallDataLoader();

            processor.AddLoader(sensorDataLoader); //Ik zou de loaders ook direct hier kunnen instantieren, maar nu zou ik er later nog naar kunnen refereren
            processor.AddLoader(twitterDataLoader);
            processor.AddLoader(callDataLoader);
            Console.WriteLine();

            processor.ProcessAll();
        }
    }
}
