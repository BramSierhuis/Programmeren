using System;

namespace Opdracht2___Structures
{
    class Program
    {
        Persoon[] personen = new Persoon[3];

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadLine();
        }

        void Start()
        {
            for(int i = 0; i < personen.Length; i++)
            {
                personen[i] = LeesPersoon();
                Console.WriteLine();
            }

            foreach(Persoon p in personen)
            {
                PrintPersoon(p);
                Console.WriteLine();
            }

            VierVerjaardag(ref personen[2]);
            PrintPersoon(personen[2]);
        }

        Persoon LeesPersoon()
        {
            Persoon p;

            p.Voornaam = LeesString("Geef voornaam: ");
            p.Achternaam = LeesString("Geef achternaam: ");
            p.Leeftijd = LeesInt("Geef leeftijd: ");
            p.Woonplaats = LeesString("Geef woonplaats: ");
            p.Geslacht = LeesGeslacht("Geef het geslacht: (m/v) ");

            return p;
        }

        void PrintPersoon(Persoon p)
        {
            Console.Write("{0} {1}, (", p.Voornaam, p.Achternaam);
            PrintGeslacht(p.Geslacht);
            Console.WriteLine(")");
            Console.WriteLine("{0} jaar, {1}", p.Leeftijd, p.Woonplaats);
        }

        int LeesInt(string vraag)
        {
            Console.Write(vraag);
            int input = int.Parse(Console.ReadLine());

            return input;
        }

        string LeesString(string vraag)
        {
            Console.Write(vraag);
            string input = Console.ReadLine();

            return input;
        }

        GeslachtType LeesGeslacht(string vraag)
        {
            string input = LeesString(vraag);
            GeslachtType g;

            while (input != "m" && input != "v")
            {
                Console.WriteLine(input + " is geen geldig geslacht.");
                input = LeesString(vraag);
            }

            if (input == "m")
                g = GeslachtType.Man;
            else 
                g = GeslachtType.Vrouw;

            return g;
        }

        void PrintGeslacht(GeslachtType geslacht)
        {
            if (geslacht == GeslachtType.Man)
                Console.Write("m");
            else
                Console.Write("v");           
        }

        void VierVerjaardag(ref Persoon jarige)
        {
            Console.WriteLine("Verjaardag vieren van " + jarige.Voornaam + " " + jarige.Achternaam + "...");
            jarige.Leeftijd++;
        }
    }
}
