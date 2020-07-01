using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht4
{
    public class ClockDisplay : IClockObserver
    {
        private int id;

        public ClockDisplay(int id)
        {
            this.id = id;
        }

        public void UpdateDisplay(DateTime time)
        {
            Console.WriteLine("[display {0}] current time: {1}", id, time.TimeOfDay);
        }
    }
}
