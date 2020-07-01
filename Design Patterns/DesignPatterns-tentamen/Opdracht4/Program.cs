using System;

namespace Opdracht4
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
            // maak kloksysteem aan
            IClockSystem clock = new ClockSystem();

            // maak een controller aan
            IClockController controller = new ClockController(clock);

            // maak een paar displays aan
            ClockDisplay display1 = new ClockDisplay(1, clock);
            ClockDisplay display2 = new ClockDisplay(2, clock);
            ClockDisplay display3 = new ClockDisplay(3, clock);

            // update de klok een paar keer
            controller.UpdateDateTime();
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);

            controller.UpdateDateTime();
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);

            controller.UpdateDateTime();
            Console.ReadKey();
        }
    }
}