using System;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }

        private void Start()
        {
            StemSysteem stemSysteem1 = StemSysteem.GetInstance();
            stemSysteem1.Stem("Bram", true);
            stemSysteem1.Stem("Jake", true);
            stemSysteem1.Stem("Klaas", false);

            StemSysteem stemSysteem2 = StemSysteem.GetInstance();
            stemSysteem1.Stem("Mark", false);

            stemSysteem1.Stem("Jake", true);
            stemSysteem1.Stem("Klaas", false);
        }
    }
}
