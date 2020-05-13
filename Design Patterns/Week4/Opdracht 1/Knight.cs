using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class Knight : Character
    {
        public Knight()
        {
            Weapon = new SwordBehaviour();
        }
    }
}
