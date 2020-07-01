using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht4
{
    public class ClockSystem : IClockSystem
    {
        private List<IClockObserver> clockDisplays = new List<IClockObserver>();

        private DateTime currentDateTime;
        public DateTime CurrentDateTime
        {
            get { return currentDateTime; }
            set { currentDateTime = value; }
        }

        public void RegisterObserver(IClockObserver display)
        {
            clockDisplays.Add(display);
        }

        public void RemoveObserver(IClockObserver display)
        {
            clockDisplays.Remove(display);
        }

        public void UpdateDateTime()
        {
            foreach(IClockObserver display in clockDisplays)
            {
                display.UpdateDisplay(DateTime.Now);
            }
        }
    }
}
