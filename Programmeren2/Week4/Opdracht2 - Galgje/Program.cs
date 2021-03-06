﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Opdracht2___Galgje
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
            GalgjeSpel galgje = new GalgjeSpel();
            List<string> woordenLijst = WoordenLijst();

            galgje.Init(SelecteerWoord(woordenLijst));

            ToonWoord(galgje.geheimWoord);

            bool result = SpeelGalgje(galgje);

            if(result)
                Console.WriteLine("Gefeliciteerd! Gewonnen!");
            else
                Console.WriteLine("Helaas! VERLOREN!");
        }

        void ToonLetters(List<char> letters)
        {
            Console.Write("Geraden letters: ");
            foreach(char c in letters)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }

        void ToonWoord(string woord)
        {
            foreach(char c in woord)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }

        char LeesLetter(ref List<char> verbodenLetters)
        {
            Console.Write("Geef een letter: ");
            char input = Convert.ToChar(Console.ReadLine());

            while (verbodenLetters.Contains(input))
            {
                Console.Write("Geef een letter: ");
                input = Convert.ToChar(Console.ReadLine());
            }

            verbodenLetters.Add(input);

            return input;
        }

        bool SpeelGalgje(GalgjeSpel spel)
        {
            List<char> ingevoerdeLetters = new List<char>();
            int pogingen = 8;

            while (pogingen > 0 && !spel.IsGeraden())
            {
                ToonWoord(spel.geradenWoord);
                Console.WriteLine();

                char geradenLetter = LeesLetter(ref ingevoerdeLetters);

                if (!spel.RaadLetter(geradenLetter))
                    pogingen--;

                Console.WriteLine("Aantal resterende pogingen: " + pogingen);    
            }

            return spel.IsGeraden();
        }

        string SelecteerWoord(List<string> woorden)
        {
            Random rnd = new Random();
            string woord = woorden[rnd.Next(0, woorden.Count)];

            return woord;
        }

        List<string> WoordenLijst()
        {
            List<string> woordenLijst = new List<string>();
            StreamReader reader = new StreamReader("../../../woorden.txt");

            while (!reader.EndOfStream)
            {
                string woord = reader.ReadLine();

                if (woord.Length >= 3)
                    woordenLijst.Add(woord);
            }

            reader.Close();

            return woordenLijst;
        }
    }
}
