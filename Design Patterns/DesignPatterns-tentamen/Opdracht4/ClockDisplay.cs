using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht4
{
    public class ClockDisplay : IClockObserver
    {
        private int id; //Wordt gebruikt om bij te houden welk dipslay er toont
        private IClockSystem klok; //Zou weggelaten kunnen worden gezien deze nu enkel in de constructor gebruikt wordt

        public ClockDisplay(int id, IClockSystem klok)
        {
            this.id = id;
            this.klok = klok;

            this.klok.RegisterObserver(this);
        }

        public void Update(DateTime time)
        {
            Console.WriteLine("[display {0}] current time: {1}", id, time.TimeOfDay);
        }
    }
}