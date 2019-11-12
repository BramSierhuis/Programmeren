using System;

namespace Opdracht1___Enumeraties
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadLine();
        }

        void Start()
        {
            PrintMaanden();
            Console.WriteLine();

            int maandValue = (int)VraagMaand("Voer een maandnummer in: ");
            Maand maand = (Maand)maandValue;

            Console.Write(maandValue + " => "); 
            PrintMaand(maand);
        }

        void PrintMaand(Maand maand)
        {
            Console.WriteLine(maand);
        }

        void PrintMaanden()
        {
            for (Maand m = Maand.Januari; m <= Maand.December; m++)
            {
                Console.Write(String.Format("{0,4}", (int) m + ". "));
                
                PrintMaand(m); 
            }
        }

        Maand VraagMaand(string vraag)
        {
            int input = LeesInt(vraag);

            while(!Enum.IsDefined(typeof(Maand), input))
            {
                Console.WriteLine(input + " is geen geldige waarde.");

                input = LeesInt(vraag);
            }

            Maand m = (Maand)input;

            return m;
        }

        int LeesInt(string vraag)
        {
            Console.Write(vraag);
            int input = int.Parse(Console.ReadLine());

            return input;
        }
    }
}
