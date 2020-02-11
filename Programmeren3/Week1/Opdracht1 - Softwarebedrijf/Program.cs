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
            Programmer nick = new Programmer("Nick", Specialty.Csharp);
            Programmer jake = new Programmer("Jake", Specialty.HTML);
            Programmer bram = new Programmer("Bram", Specialty.Java);

            Team team = new Team();
            team.AddProgrammer(nick);
            team.AddProgrammer(jake);
            team.AddProgrammer(bram);

            team.PrintAllTeamMembers();
        }
    }
}
