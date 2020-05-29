using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_2
{
    public class NoCardState : IATMState
    {
        private ATMMachine machine;

        public NoCardState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode(uint pin)
        {
            Console.WriteLine("Please insert a card first");
        }

        public void InsertCard()
        {
            Console.WriteLine("Please enter your pincode");
            machine.SetMachineState(machine.GetCardPresentState());
        }

        public void RejectCard()
        {
            Console.WriteLine("There is no card, so it can't be rejected");
        }

        public void WithdrawCash(uint amount)
        {
            Console.WriteLine("Please insert a card first");
        }
    }
}
