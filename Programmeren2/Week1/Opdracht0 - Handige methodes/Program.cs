using System;

namespace Opdracht0___Handige_methodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            int getal = LeesInt("tik een getal: ");
            Console.WriteLine("Je hebt {0} ingetikt.", getal);

            int leeftijd = LeesInt("hoe oud ben je? ", 0, 120);
            Console.WriteLine("Je bent {0} jaar oud.", leeftijd);

            string naam = LeesString("Hoe heet je? ");
            Console.WriteLine("Aangenaam kennis met je te maken, {0}.", naam);

            Console.ReadKey();
        }

        int LeesInt(string vraag)
        {
            Console.Write(vraag);
            int input = int.Parse(Console.ReadLine());

            return input;
        }

        string LeesString(string vraag)
        {
            Console.Write(vraag);
            string input = Console.ReadLine();

            return input;
        }

        int LeesInt(string vraag, int min, int max)
        {
            Console.Write(vraag);
            int input = int.Parse(Console.ReadLine());

            while(input < min || input > max)
            {
                Console.Write(vraag);
                input = int.Parse(Console.ReadLine());
            }

            return input;
        }
    }
}
