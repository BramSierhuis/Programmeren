using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1___Softwarebedrijf
{
    public class Team
    {
        List<Programmer> programmers;

        public Team()
        {
            programmers = new List<Programmer>(); //Dit kan ook gewoon bij het aanmaken van de variable gebeuren toch?
        }

        public void AddProgrammer(Programmer p)
        {
            programmers.Add(p);
        }

        public void PrintAllTeamMembers()
        {
            foreach (Programmer p in programmers)
            {
                p.Print();
            }
        }
    }
}
