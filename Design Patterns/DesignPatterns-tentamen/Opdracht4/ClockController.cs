using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht4
{
    public class ClockController : IClockController
    {
        private IClockSystem clockSystem;

        public ClockController(IClockSystem clockSystem)
        {
            this.clockSystem = clockSystem;
        }

        public void UpdateDateTime()
        {
            clockSystem.UpdateDateTime();
        }
    }
}
