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

        private void Start()
        {
            Logger.Instance.Log("main", "starting");

            MainSystem mainSystem = new MainSystem(); //This could be a one-liner
            SubSystem subSystem = new SubSystem();

            mainSystem.DoSomeMainWork(); //                     ^^
            subSystem.DoSomeWork();
            subSystem.DoSomeWork();

            Logger.Instance.Log("main", "finishing");
        }
    }
}
