using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            IPencil pencil = new Pencil(20);
            IPencilSharpener pencilSharpener = new PencilSharpener();

            string input;
            while (true)
            {
                Console.Write("Enter a word: ");
                input = Console.ReadLine();

                if (input == "stop")
                    return;

                if (input == "sharpen")
                    pencilSharpener.Sharpen(pencil);
                else
                    pencil.Write(input);
            }
        }
    }
}
