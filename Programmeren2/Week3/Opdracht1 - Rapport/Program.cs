using System;
using System.Collections.Generic;

namespace Opdracht1___Rapport
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadKey();
        }

        void Start()
        {
            List<Vak> rapport = LeesRapport();

            ToonRapport(rapport);
        }

        PraktijkBeoordeling LeesPraktijkBeoordeling(string vraag)
        {
            Console.Write(vraag);
            PraktijkBeoordeling input = (PraktijkBeoordeling) Enum.Parse(typeof(PraktijkBeoordeling), Console.ReadLine());

            return input;
        }

        void ToonPraktijkBeoordeling(PraktijkBeoordeling praktijkBeoordeling)
        {
            Console.WriteLine(praktijkBeoordeling.ToString());
        }

        Vak LeesVak(string vraag)
        {
            Console.WriteLine(vraag);
            Console.Write("Wat is de naam van het vak?: ");
            string naam = Console.ReadLine();

            Console.Write("Wat is het behaalde cijfer: ");
            int cijfer = int.Parse(Console.ReadLine());

            Console.Write("");
            PraktijkBeoordeling praktijkBeoordeling = LeesPraktijkBeoordeling("Wat is de praktijkbeoordeling?: ");

            return new Vak(naam, cijfer, praktijkBeoordeling);
        }

        void ToonVak(Vak vak)
        {
            Console.Write("{0, 5}    |    {1, 3}    |    ", vak.naam, vak.cijfer);
            ToonPraktijkBeoordeling(vak.praktijkBeoordeling);
        }

        List<Vak> LeesRapport()
        {
            List<Vak> rapport = new List<Vak>();

            Console.WriteLine("Geef 3 vakken op: ");

            rapport.Add(LeesVak("Geef vak 1: "));
            Console.WriteLine();

            rapport.Add(LeesVak("Geef vak 2: "));
            Console.WriteLine();

            rapport.Add(LeesVak("Geef vak 3: "));
            Console.WriteLine();

            return rapport;
        }

        void ToonRapport(List<Vak> rapport)
        {
            int cumlaude = 0;
            int gehaald = 0;

            Console.WriteLine("De vakken in dit rapport: ");

            foreach(Vak vak in rapport)
            {
                ToonVak(vak);

                if (IsCumLaude(vak))
                    cumlaude++;
                else if (IsBehaald(vak))
                    gehaald++;
            }

            if(cumlaude == 3)
                Console.WriteLine("Gefeliciteerd, je bent CUMLAUDE geslaagd");
            else if(gehaald == 3)
                Console.WriteLine("Gefeliciteerd, je bent geslaagd");
            else
            {
                int herkansingen = 3 - gehaald;

                Console.WriteLine("Helaas, je bent gezakt en hebt {0} herkansingen", herkansingen);
            }
        }

        public bool IsBehaald(Vak vak)
        {
            if (vak.cijfer >= 55 && (vak.praktijkBeoordeling == PraktijkBeoordeling.Goed || vak.praktijkBeoordeling == PraktijkBeoordeling.Voldoende))
                return true;
            else
                return false;
        }

        public bool IsCumLaude(Vak vak)
        {
            if (vak.cijfer >= 80 && vak.praktijkBeoordeling == PraktijkBeoordeling.Goed)
                return true;
            else
                return false;
        }
    }
}
