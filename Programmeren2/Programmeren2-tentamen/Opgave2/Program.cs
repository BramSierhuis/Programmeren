using System;

namespace Opgave2
{
    class Program
    {
        const int ROWS = 15;
        const int COLUMNS = 20;
        const int MIN = 1;
        const int MAX = 201;

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadKey();
        }

        void Start()
        {
            int[,] matrix = new int[ROWS, COLUMNS];

            VulMatrix(ref matrix);
            ToonMatrix(matrix);

            Positie kleinste = ZoekKleinste(matrix);
            Positie grootste = ZoekGrootste(matrix);

            Console.WriteLine();
            ToonPositie("Kleinste", kleinste);
            ToonPositie("Grootste", grootste);
            Console.WriteLine();

            ToonMatrixPosities(matrix, grootste, kleinste);
        }

        void VulMatrix(ref int[,] matrix)
        {
            Random random = new Random();

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = random.Next(MIN, MAX);
                }
            }
        }

        void ToonMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write("{0, 4}", matrix[r, c]);
                }

                Console.WriteLine();
            }
        }

        void ToonPositie(string naam, Positie pos)
        {
            Console.WriteLine("{0}: {1} (rij: {2}, kolom: {3}", naam, pos.waarde, pos.rij, pos.kolom);
        }

        void ToonMatrixPosities(int[,] matrix, Positie grootste, Positie kleinste)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    //De {} om deze if statements zijn niet nodig, maar ze verhogen wel de leesbaarheid
                    if (c == kleinste.kolom || r == kleinste.rij)
                    {
                        if (matrix[r, c] == kleinste.waarde)
                            Console.BackgroundColor = ConsoleColor.Blue;
                        else
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                    }
                    else if (c == grootste.kolom || r == grootste.rij)
                    {
                        if (matrix[r, c] == grootste.waarde)
                            Console.BackgroundColor = ConsoleColor.Red;
                        else
                            Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.Write("{0, 4}", matrix[r, c]);

                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }

        Positie ZoekKleinste(int[,] matrix)
        {
            int kleinste = MAX;
            int rij = 0;
            int kolom = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] < kleinste)
                    {
                        kleinste = matrix[r, c];
                        rij = r;
                        kolom = c;
                    }
                        
                }
            }

            return new Positie(rij, kolom, kleinste);
        }
        
        Positie ZoekGrootste(int[,] matrix)
        {
            int grootste = MIN;
            int rij = 0;
            int kolom = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] > grootste)
                    {
                        grootste = matrix[r, c];
                        rij = r;
                        kolom = c;
                    }
                        
                }
            }

            return new Positie(rij, kolom, grootste);
        }
    }
}
