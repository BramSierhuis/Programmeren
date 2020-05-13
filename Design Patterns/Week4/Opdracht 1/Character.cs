using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public abstract class Character
    {
        public IWeaponBehaviour Weapon { get; set; }

        public void Fight()
        {
            Weapon.UseWeapon();
        }
    }
}
