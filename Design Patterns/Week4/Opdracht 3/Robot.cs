using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_3
{
    public class Robot
    {
        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands");
        }

        public void MoveByPerson(string name)
        {
            Console.WriteLine("Robot is moved by " + name);
        }

        public void WalkForward()
        {
            Console.WriteLine("Robot walks 3 steps forward");
        }
    }
}
