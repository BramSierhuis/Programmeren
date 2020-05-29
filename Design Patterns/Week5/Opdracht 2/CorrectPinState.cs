using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_2
{
    public class CorrectPinState : IATMState
    {
        private ATMMachine machine;

        public CorrectPinState(ATMMachine machine)
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
            if(machine.AmountInMachine < amount)
            {
                Console.WriteLine("Not enough cash in the machine");
                machine.SetMachineState(machine.GetNoCashState());
            } else if(machine.AmountInMachine == amount)
            {
                Console.WriteLine(amount + " has been withdrawn");
                machine.SetAmountInMachine(0);
                machine.SetMachineState(machine.GetNoCashState());
            }
            else
            {
                Console.WriteLine(amount + " has been withdrawn");
                machine.SetAmountInMachine(machine.AmountInMachine - amount);
            }

            RejectCard();
        }
    }
}
