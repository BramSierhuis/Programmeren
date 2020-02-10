using System;

namespace Opdracht1___Softwarebedrijf
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
            Programmer nick = new Programmer("Nick", Enums.Specialty.Csharp);
            Programmer jake = new Programmer("Jake", Enums.Specialty.HTML);
            Programmer bram = new Programmer("Bram", Enums.Specialty.Java);

            
        }
    }
}
