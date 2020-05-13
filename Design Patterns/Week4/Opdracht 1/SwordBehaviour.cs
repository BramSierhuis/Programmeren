using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class SwordBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Slashing with a sword");
        }
    }
}
