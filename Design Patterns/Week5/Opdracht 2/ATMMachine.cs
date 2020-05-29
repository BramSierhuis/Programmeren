using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_2
{
    public class ATMMachine
    {
        private uint amountInMachine;
        public uint AmountInMachine { get { return amountInMachine; } }

        private IATMState noCard;
        private IATMState cardPresent;
        private IATMState correctPincode;
        private IATMState noCash;

        private IATMState machineState;

        public ATMMachine(uint amountInMachine)
        {
            this.amountInMachine = amountInMachine;

            noCard = new NoCardState(this);
            cardPresent = new CardPresentState(this);
            correctPincode = new CorrectPinState(this);
            noCash = new NoCashState(this);

            if (amountInMachine > 0)
                machineState = noCard;
            else
                machineState = noCash;
        }

        public void InsertCard()
        {
            machineState.InsertCard();
        }

        public void RejectCard()
        {
            machineState.RejectCard();
        }

        public void EnterPincode(uint pin)
        {
            machineState.EnterPincode(pin);
        }

        public void WithdrawCash(uint amount)
        {
            machineState.WithdrawCash(amount);
        }

        public IATMState GetNoCardState()
        {
            return noCard;
        }

        public IATMState GetCardPresentState()
        {
            return cardPresent;
        }

        public IATMState GetCorrectPinState()
        {
            return correctPincode;
        }

        public IATMState GetNoCashState()
        {
            return noCash;
        }

        public void SetAmountInMachine(uint amount)
        {
            amountInMachine = amount;
        }

        public void SetMachineState(IATMState state)
        {
            machineState = state;
        }
    }
}
