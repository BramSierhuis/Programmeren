using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_3
{
    public class Pencil : IPencil
    {
        private int maxToWrite; // number of characters to write with a sharpened pencil
        private int nrOfCharsWritten = 0; // number of written characters

        public bool CanWrite 
        { 
            get
            {
                if (nrOfCharsWritten < maxToWrite)
                    return true;
                else
                    return false;
            } 
        }

        public Pencil(int maxToWrite)
        {
            this.maxToWrite = maxToWrite;
        }

        public void AfterSharpening()
        {
            nrOfCharsWritten = 0;
        }

        public void Write(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach(char letter in message)
            {
                if (CanWrite)
                    Console.Write(letter);
                else
                    Console.Write("#");

                nrOfCharsWritten++;
            }

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
