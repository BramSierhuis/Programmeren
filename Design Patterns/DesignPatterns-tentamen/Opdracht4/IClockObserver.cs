using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht4
{
    public interface IClockObserver
    {
        void Update(DateTime time);
    }
}
