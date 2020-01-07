using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht___Chess
{
    public class ChessPiece
    {
        public ChessPieceColor color;
        public ChessPieceType type;

        public ChessPiece(ChessPieceColor color, ChessPieceType type)
        {
            this.color = color;
            this.type = type;
        }
    }
}
