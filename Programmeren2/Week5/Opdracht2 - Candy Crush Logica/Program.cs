using System;
using System.IO;
using CandyCrushLogica;

namespace Opdracht3___Candy_Crush
{
    class Program
    {
        Random rnd = new Random();
        const string PATH = "../../../";

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadKey();
        }

        void Start()
        {
            Enums.RegularCandies[,] speelveld = new Enums.RegularCandies[9, 9];

            if (File.Exists(PATH + "veld.txt"))
            {
                Console.WriteLine("Een bestaand veld is opgeslagen...");
                InitCandies(ref speelveld, "veld.txt");
            }
            else
            {
                Console.WriteLine("Nieuw veld wordt gegenereerd...");
                InitCandies(ref speelveld);
                SchrijfSpeelveld(speelveld, "veld.txt");
            }

            Console.WriteLine();
            PrintCandies(speelveld);

            SchrijfSpeelveld(speelveld, "veld.txt");

            if(CandyCrusher.ScoreRijAanwezig(speelveld))
                Console.WriteLine("Er is een score rij aanwezig");
            else
                Console.WriteLine("Er is GEEN score rij aanwezig"); 
            
            if(CandyCrusher.ScoreKolomAanwezig(speelveld))
                Console.WriteLine("Er is een score kolom aanwezig");
            else
                Console.WriteLine("Er is GEEN score kolom aanwezig");
        }

        void InitCandies(ref Enums.RegularCandies[,] speelveld)
        {
            int rows = speelveld.GetLength(0);
            int columns = speelveld.GetLength(1);

            int candies = Enum.GetNames(typeof(Enums.RegularCandies)).Length;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    speelveld[r, c] = (Enums.RegularCandies) rnd.Next(0, candies);
                }
            }
        }

        void InitCandies(ref Enums.RegularCandies[,] speelveld, string bestandsnaam)
        {
            try
            {
                speelveld = LeesSpeelveld(bestandsnaam);
            }
            catch(Exception e)
            {
                Console.WriteLine("An error has occured: " + e.Message);
                Console.WriteLine("Creating a new random field...");
                
                InitCandies(ref speelveld);
            }
        }

        void PrintCandies(Enums.RegularCandies[,] speelveld)
        {
            int rows = speelveld.GetLength(0);
            int columns = speelveld.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Enums.RegularCandies toPrint = speelveld[r, c];

                    switch (toPrint)
                    {
                        case Enums.RegularCandies.JellyBean:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;

                        case Enums.RegularCandies.Lozenge:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;

                        case Enums.RegularCandies.LemonDrop:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;

                        case Enums.RegularCandies.GumSquare:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;

                        case Enums.RegularCandies.LollipopHead:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;

                        case Enums.RegularCandies.JujubeCluster:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;

                        default:
                            Console.ResetColor();
                            break;
                    }

                    Console.Write("# ");
                }

                Console.WriteLine();
            }

            Console.ResetColor();
        }

        void SchrijfSpeelveld(Enums.RegularCandies[,] speelveld, string bestandsnaam)
        {
            StreamWriter sw = new StreamWriter(PATH + bestandsnaam);

            int rows = speelveld.GetLength(0);
            int columns = speelveld.GetLength(1);

            sw.WriteLine(rows);
            sw.WriteLine(columns);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    sw.Write((int) speelveld[r, c] + " ");
                }

                sw.WriteLine();
            }

            sw.Close();
        }

        Enums.RegularCandies[,] LeesSpeelveld(string bestandsnaam)
        {
            StreamReader sr = new StreamReader(PATH + bestandsnaam);

            try
            {
                int rows = int.Parse(sr.ReadLine());
                int columns = int.Parse(sr.ReadLine());

                Enums.RegularCandies[,] speelveld = new Enums.RegularCandies[rows, columns];

                for (int r = 0; r < rows; r++)
                {
                    string regel = sr.ReadLine();
                    string[] candies = regel.Split(' ');

                    for (int c = 0; c < columns; c++)
                    {
                        speelveld[r, c] = (Enums.RegularCandies)int.Parse(candies[c]);
                    }
                }

                sr.Close();

                return speelveld;
            }
            catch (Exception e)
            {
                sr.Close();

                throw e;
            }
        }
    }
}
