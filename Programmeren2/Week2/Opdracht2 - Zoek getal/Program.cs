using System;

namespace Opdracht2___Zoek_getal
{
    class Program
    {
        int[,] myMatrix;

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadKey();
        }

        void Start()
        {
            Console.Write("Geef de grootte van de matrix: ");
            int size = int.Parse(Console.ReadLine());

            myMatrix = new int[size, size];

            //InitMatrix2D(myMatrix);
            InitMatrixRandom(myMatrix, 1, 10);
            PrintMatrix(myMatrix);

            Console.Write("Geef het getal om naar te zoeken: ");
            int zoekGetal = int.Parse(Console.ReadLine());

            Positie pos = ZoekGetalAchterwaards(myMatrix, zoekGetal);

            Console.WriteLine("[{0}, {1}]", pos.row, pos.column);
        }

        void InitMatrixRandom(int[,] matrix, int min, int max)
        {
            Random rnd = new Random();

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = rnd.Next(min, max);
                }
            }

            myMatrix = matrix;
        }

        void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write("{0, 4}", matrix[r, c]);
                }

                Console.WriteLine();
            }
        }

        Positie ZoekGetal(int[,] matrix, int zoekGetal)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (matrix[r, c] == zoekGetal)
                        return new Positie(r, c);
                }
            }

            return null;
        }

        Positie ZoekGetalAchterwaards(int[,] matrix, int zoekGetal)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int r = rows - 1; r >= 0; r--)
            {
                for (int c = columns - 1; c >= 0; c--)
                {
                    if (matrix[r, c] == zoekGetal)
                        return new Positie(r, c);
                }
            }

            return null;
        }
    }
}
