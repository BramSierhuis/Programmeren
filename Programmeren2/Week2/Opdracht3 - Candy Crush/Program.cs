using System;

namespace Opdracht3___Candy_Crush
{
    class Program
    {
        Random rnd = new Random();

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadKey();
        }

        void Start()
        {
            RegularCandies[,] speelveld = new RegularCandies[9, 9];

            InitCandies(ref speelveld);
            PrintCandies(speelveld);

            if(ScoreRijAanwezig(speelveld))
                Console.WriteLine("Er is een score rij aanwezig");
            else
                Console.WriteLine("Er is GEEN score rij aanwezig"); 
            
            if(ScoreKolomAanwezig(speelveld))
                Console.WriteLine("Er is een score kolom aanwezig");
            else
                Console.WriteLine("Er is GEEN score kolom aanwezig");
        }

        void InitCandies(ref RegularCandies[,] speelveld)
        {
            int rows = speelveld.GetLength(0);
            int columns = speelveld.GetLength(1);

            int candies = Enum.GetNames(typeof(RegularCandies)).Length;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    speelveld[r, c] = (RegularCandies) rnd.Next(0, candies);
                }
            }
        }

        void PrintCandies(RegularCandies[,] speelveld)
        {
            int rows = speelveld.GetLength(0);
            int columns = speelveld.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    RegularCandies toPrint = speelveld[r, c];

                    switch (toPrint)
                    {
                        case RegularCandies.JellyBean:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;

                        case RegularCandies.Lozenge:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;

                        case RegularCandies.LemonDrop:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;

                        case RegularCandies.GumSquare:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;

                        case RegularCandies.LollipopHead:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;

                        case RegularCandies.JujubeCluster:
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

        bool ScoreRijAanwezig(RegularCandies[,] speelveld)
        {
            int rows = speelveld.GetLength(0);
            int columns = speelveld.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                int counter = 1;
                RegularCandies prev = new RegularCandies();

                for (int c = 0; c < columns; c++)
                {
                    RegularCandies currentCandy = speelveld[r, c];

                    if (c == 0)
                    {
                        prev = currentCandy;
                        continue;
                    }

                    if (currentCandy == prev)
                        counter++;
                    else
                        counter = 1;

                    if (counter == 3)
                        return true;

                    prev = currentCandy;
                }
            }

            return false;
        }

        bool ScoreKolomAanwezig(RegularCandies[,] speelveld)
        {
            int rows = speelveld.GetLength(0);
            int columns = speelveld.GetLength(1);

            for (int c = 0; c < columns; c++)
            {
                int counter = 1;
                RegularCandies prev = new RegularCandies();

                for (int r = 0; r < rows; r++)
                {
                    RegularCandies currentCandy = speelveld[r, c];

                    if (r == 0)
                    {
                        prev = currentCandy;
                        continue;
                    }

                    if (currentCandy == prev)
                        counter++;
                    else
                        counter = 1;

                    if (counter == 3)
                        return true;

                    prev = currentCandy;
                }
            }

            return false;
        }
    }
}
