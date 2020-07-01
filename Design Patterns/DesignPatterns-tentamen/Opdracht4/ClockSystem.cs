using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht4
{
    public class ClockSystem : IClockSystem
    {
        private List<IClockObserver> displays = new List<IClockObserver>();

        private DateTime currentDateTime;
        public DateTime CurrentDateTime
        {
            get { return currentDateTime; }
            set { currentDateTime = value; }
        }

        public void RegisterObserver(IClockObserver display)
        {
            displays.Add(display);
        }

        public void RemoveObserver(IClockObserver display)
        {
            displays.Remove(display);
        }

        public void NotifyObservers() //Ik heb er voor gekozen deze functie uit de UpdateDateTime functie te halen
        {
            foreach (IClockObserver display in displays)
            {
                display.Update(DateTime.Now);
            }
        }

        public void UpdateDateTime()
        {
            currentDateTime = DateTime.Now;

            NotifyObservers();
        }
    }
}