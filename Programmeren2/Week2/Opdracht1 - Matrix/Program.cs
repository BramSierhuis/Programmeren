using System;

namespace Opdracht1___Matrix
{
    class Program
    {
        Random rnd = new Random();
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
            InitMatrixLineair(myMatrix);
            PrintMatrixWithCross(myMatrix);
        }

        void InitMatrix2D(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for(int c = 0; c < columns; c++)
                {
                    matrix[r, c] = r * columns + c + 1;
                }
            }

            myMatrix = matrix;
        }

        void InitMatrixLineair(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int size = rows * columns;

            for (int i = 0; i < size; i++)
            {
                int column = i % columns;
                int row = i / columns;

                matrix[row, column] = i + 1;
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

        void PrintMatrixWithCross(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (r == c)
                        Console.ForegroundColor = ConsoleColor.Red;

                    if (r + c == columns - 1)
                        Console.BackgroundColor = ConsoleColor.Yellow;

                    Console.Write("{0, 4}", matrix[r, c]);

                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }
    }
}
