using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1___Softwarebedrijf
{
    class Programmer
    {
        string name;
        Enums.Specialty specialty;

        public Programmer(string name, Enums.Specialty specialty)
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
