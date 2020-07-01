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
    }
}
