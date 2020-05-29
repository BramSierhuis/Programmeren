using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_2
{
    public class NoCashState : IATMState
    {
        private ATMMachine machine;

        public NoCashState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode(uint pin)
        {
            Console.WriteLine("A pin has already been entered");
        }

        public void InsertCard()
        {
            Console.WriteLine("There already is a card in the slot");
        }

        public void RejectCard()
        {
            Console.WriteLine("Card has been rejected");
            machine.SetMachineState(machine.GetNoCardState());
        }

        public void WithdrawCash(uint amount)
        {
            Console.WriteLine("Not enough cash in the machine");
        }
    }
}
