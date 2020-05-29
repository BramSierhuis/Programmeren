using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_2
{
    public interface IATMState
    {
        void InsertCard();
        void RejectCard();
        void EnterPincode(uint pin);
        void WithdrawCash(uint amount);
    }
}
