using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_3
{
    public interface IAttacker
    {
        void AssignDriver(string name);
        void DriveForward();
        void UseWeapon();
    }
}
