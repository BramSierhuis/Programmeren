using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class SubSystem
    {
        public void DoSomeWork()
        {
            Logger.Instance.Log("Subsystem", "doing some work");
        }

        public void DoSomeMoreWork()
        {
            Logger.Instance.Log("Subsystem", "doing some more work");
        }
    }
}
