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
            StemSysteem stemSysteem1 = StemSysteem.Instance;
            stemSysteem1.Stem("Bram", true);
            stemSysteem1.Stem("Jake", true);
            stemSysteem1.Stem("Klaas", false);

            StemSysteem stemSysteem2 = StemSysteem.Instance;
            stemSysteem2.Stem("Mark", false);

            stemSysteem2.Stem("Jake", true);
            stemSysteem2.Stem("Klaas", false);
        }
    }
}
