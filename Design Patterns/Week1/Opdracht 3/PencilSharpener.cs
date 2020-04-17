using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_3
{
    public class PencilSharpener : IPencilSharpener
    {
        public void Sharpen(IPencil pencil)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Sharpening pencil...");
            Console.ResetColor();

            pencil.AfterSharpening();
        }
    }
}
