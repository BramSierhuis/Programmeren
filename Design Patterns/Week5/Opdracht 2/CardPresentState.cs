using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_2
{
    public class CardPresentState : IATMState
    {
        private ATMMachine machine;

        public CardPresentState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode(uint pin)
        {
            Console.WriteLine("Correct pin has been entered");
            machine.SetMachineState(machine.GetCorrectPinState());
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
            Console.WriteLine("A pin has to be entered first");
        }
    }
}
