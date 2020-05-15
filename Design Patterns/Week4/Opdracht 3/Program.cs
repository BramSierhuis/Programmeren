using System;
using System.Collections.Generic;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }

        void Start()
        {
            IAttacker tank = new Tank();
            tank.AssignDriver("Bram");

            IAttacker robot = new RobotAdapter(new Robot());
            robot.AssignDriver("Frank");

            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(tank);
            attackers.Add(robot);

            foreach (IAttacker attacker in attackers)
            {
                attacker.DriveForward();
                attacker.UseWeapon();
            }
        }
    }
}
