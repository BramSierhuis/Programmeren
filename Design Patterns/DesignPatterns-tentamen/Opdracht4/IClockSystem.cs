using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht4
{
    public interface IClockSystem
    {
        void UpdateDateTime();
        void RegisterObserver(IClockObserver display);
        void RemoveObserver(IClockObserver display);
        void NotifyObservers(); //Ik heb er voor gekozen deze functie uit de UpdateDateTime functie te halen
    }
}
