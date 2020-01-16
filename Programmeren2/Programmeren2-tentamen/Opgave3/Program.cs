using System;
using System.Collections.Generic;
using System.IO;

namespace Opgave3
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
            List<Plaat> platen = LeesPlaten("../../../top2000-2019.csv");

            Console.WriteLine("Aantal ingelezen platen: " + platen.Count);

            if (platen.Count == 0)
                return;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("'dubbele' artiesten");
            Console.ResetColor();

            ToonDubbeleArtiesten(DubbeleArtiesten(platen));

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("veel voorkomende titels");
            Console.ResetColor();

            ToonDubbeleTitels(DubbeleTitels(platen));
            
            Console.WriteLine();
            ToonPlaten(platen);
        }
        void ToonPlaten(List<Plaat> platen)
        {
            foreach (Plaat plaat in platen)
                Console.WriteLine("{0}. {1} - {2}", plaat.ranking, plaat.artiest, plaat.titel);          
        }

        void ToonDubbeleArtiesten(List<string> dubbeleArtiesten)
        {
            foreach (string artiest in dubbeleArtiesten)
                Console.WriteLine(artiest);
        }

        void ToonDubbeleTitels(Dictionary<string, List<Plaat>> titelPlaten)
        {
            foreach (KeyValuePair<string, List<Plaat>> kvp in titelPlaten)
            {
                List<Plaat> platen = kvp.Value;
                int count = platen.Count;

                if(count >= 3)
                {
                    Console.WriteLine("{0} ({1}x)", kvp.Key, count);

                    foreach(Plaat plaat in platen)
                        Console.WriteLine("{0, 8}. {1}", plaat.ranking, plaat.artiest);
                }
            }
        }

        List<Plaat> LeesPlaten(string bestand)
        {
            List<Plaat> platen = new List<Plaat>();

            if(!File.Exists(bestand))
                return platen;

            StreamReader sr = new StreamReader(bestand);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] plaatInfo = line.Split(';');

                Plaat plaat = new Plaat(int.Parse(plaatInfo[0]), plaatInfo[1], plaatInfo[2], int.Parse(plaatInfo[3]));
                platen.Add(plaat);
            }

            sr.Close();
        
            return platen;
        }

        List<string> DubbeleArtiesten(List<Plaat> platen)
        {
            string previous = "";
            List<string> dubbeleArtiesten = new List<string>();

            foreach(Plaat plaat in platen)
            {
                string artiest = plaat.artiest;

                if (artiest == previous && !dubbeleArtiesten.Contains(artiest))
                    dubbeleArtiesten.Add(artiest);

                previous = artiest;
            }

            return dubbeleArtiesten;
        }

        Dictionary<string, List<Plaat>> DubbeleTitels(List<Plaat> platen)
        {
            Dictionary<string, List<Plaat>> platenDict = new Dictionary<string, List<Plaat>>();

            foreach(Plaat plaat in platen)
            {
                if (platenDict.ContainsKey(plaat.titel))
                    platenDict[plaat.titel].Add(plaat);
                else
                {
                    List<Plaat> platenMetDezeTitel = new List<Plaat>();
                    platenMetDezeTitel.Add(plaat);

                    platenDict.Add(plaat.titel, platenMetDezeTitel);
                }
            }

            return platenDict;
        }
    }
}
