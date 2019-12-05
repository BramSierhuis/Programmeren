using System;
using System.IO;

namespace Opdracht1___Gegevensopslag
{
    class Program
    {
        string path = "../../../Personen/";

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadKey();
        }

        void Start()
        {
            Console.Write("Wat is uw naam? ");
            string naam = Console.ReadLine();

            if(File.Exists(path + naam))
            {
                Console.WriteLine("Wat leuk om je weer te zien!");
                ToonPersoon(LeesPersoon(naam));
            }
            else
            {
                Console.WriteLine("Hey, jij bent nieuw. Kun je nog eens je naam invoeren?");
                Persoon persoon = LeesPersoon();
                SchrijfPersoon(persoon, persoon.naam);
            }
        }

        Persoon LeesPersoon()
        {
            Console.Write("Geef de naam van de persoon: ");
            string naam = Console.ReadLine();

            Console.Write("Geef de leeftijd van de persoon: ");
            int leeftijd = int.Parse(Console.ReadLine());

            Console.Write("Geef ook zijn woonplaats: ");
            string woonplaats = Console.ReadLine();

            return new Persoon(naam, leeftijd, woonplaats);
        }

        void ToonPersoon(Persoon persoon)
        {
            Console.WriteLine("Dit is {0}, {1} jaar oud. Wonend in {2}", persoon.naam, persoon.leeftijd, persoon.woonplaats);
        }

        void SchrijfPersoon(Persoon p, string fileName)
        {
            try
            {
                StreamWriter writer = new StreamWriter(path + fileName);

                writer.WriteLine(p.naam);
                writer.WriteLine(p.leeftijd);
                writer.WriteLine(p.woonplaats);

                writer.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Persoon LeesPersoon(string fileName)
        {
            try
            {
                StreamReader reader = new StreamReader(path + fileName);

                string naam = reader.ReadLine();
                int leeftijd = int.Parse(reader.ReadLine());
                string woonplaats = reader.ReadLine();

                reader.Close();

                return new Persoon(naam, leeftijd, woonplaats);
            }
            catch(Exception e)
            {
                Console.WriteLine("Leespersoon ERROR");
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
