using System;
using System.Text.RegularExpressions;

namespace Opdracht___Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }

        void Start()
        {
            ChessPiece[,] chessboard = new ChessPiece[8, 8];

            InitChessboard(ref chessboard);
            DisplayChessboard(chessboard);
        }

        void InitChessboard(ref ChessPiece[,] chessboard)
        {
            for (int r = 0; r < chessboard.GetLength(0); r++)
            {
                for (int c = 0; c < chessboard.GetLength(1); c++)
                {
                    chessboard[r, c] = null;
                }
            }

            PutChessPieces(ref chessboard);
        }

        void DisplayChessboard(ChessPiece[,] chessboard)
        {
            Console.WriteLine("   A  B  C  D  E  F  G  H ");
            for (int r = 0; r < chessboard.GetLength(0); r++)
            {
                Console.Write(r + 1 + " ");
                for (int c = 0; c < chessboard.GetLength(1); c++)
                {
                    if ((r + c) % 2 == 0)
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    else
                        Console.BackgroundColor = ConsoleColor.Gray;

                    DisplayChessPiece(chessboard[r, c]);
                }

                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        void PutChessPieces(ref ChessPiece[,] chessboard)
        {
            ChessPieceType[] order = { ChessPieceType.Rook, ChessPieceType.Knight, ChessPieceType.Bishop, ChessPieceType.King, 
                                       ChessPieceType.Queen, ChessPieceType.Bishop, ChessPieceType.Knight, ChessPieceType.Rook };

            for (int r = 0; r < chessboard.GetLength(0); r++)
            {
                for (int c = 0; c < chessboard.GetLength(1); c++)
                {
                    if(r == 0)
                        chessboard[r, c] = new ChessPiece(ChessPieceColor.White, order[c]);
                    else if(r == 1)
                        chessboard[r, c] = new ChessPiece(ChessPieceColor.White, ChessPieceType.Pawn);
                    else if(r == 6)
                        chessboard[r, c] = new ChessPiece(ChessPieceColor.Black, ChessPieceType.Pawn);                    
                    else if(r == 7)
                        chessboard[r, c] = new ChessPiece(ChessPieceColor.Black, order[c]); 
                }
            }
        }

        void DisplayChessPiece(ChessPiece chessPiece)
        {
            if (chessPiece == null)
                Console.Write("   ");
            else
            {
                if (chessPiece.color == ChessPieceColor.Black)
                    Console.ForegroundColor = ConsoleColor.Black;
                else
                    Console.ForegroundColor = ConsoleColor.White;

                char type = chessPiece.type.ToString()[0];
                if (chessPiece.type == ChessPieceType.King || chessPiece.type == ChessPieceType.Queen)
                    Console.Write(" {0} ", type);
                else
                    Console.Write(" {0} ", Char.ToLower(type));
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        void PlayChess(ChessPiece[,] chessBoard)
        {
            
        }

        Position ReadPosition(string question)
        {
            string input;

            while (true)
            {
                try
                {
                    Console.Write(question);
                    input = Console.ReadLine();

                    if (input.Length > 2)
                        throw new Exception("The input can't be longer than 2 characters. Try again.");
                    else if ((Regex.Matches(input[0].ToString(), @"[A-H]").Count + Regex.Matches(input[1].ToString(), @"[1-8]").Count) < 2)
                        throw new Exception("The input has te be a valid chess move, this isn't possible. Try again.");

                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            int column = input[0] - 'A';
            int row = int.Parse(input[1].ToString()) - 1;

            return new Position(row, column);
        }
    }
}
