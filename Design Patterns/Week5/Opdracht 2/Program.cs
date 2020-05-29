using System;

namespace Opdracht_2
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
            ATMMachine machine = new ATMMachine(2000);

            machine.InsertCard();
            machine.RejectCard();

            machine.InsertCard();
            machine.EnterPincode(1234);
            machine.WithdrawCash(1500);

            machine.InsertCard();
            machine.EnterPincode(1234);
            machine.WithdrawCash(750);
        }
    }
}
