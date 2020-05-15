using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_3
{
    public class Tank : IAttacker
    {
        public void AssignDriver(string name)
        {
            Console.WriteLine(name + " is steering the tank");
        }

        public void DriveForward()
        {
            Console.WriteLine("Tank rolls 3 positions forward");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank shot a shell");
        }
    }
}
