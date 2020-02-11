using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1___Softwarebedrijf
{
    public class Programmer
    {
        string name;
        Specialty specialty;

        public Programmer(string name)
        {
            this.name = name;
            specialty = Specialty.Unknown;
        }

        public Programmer(string name, Specialty specialty)
        {
            this.name = name;
            this.specialty = specialty;
        }

        public void Print()
        {
            Console.WriteLine("Name: {0}, Specialty: {1}", name, specialty);
        }
    }
}
