using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) //Een loop die doorgaat totdat een getal kleiner dan 1 wordt ingevuld
            {
                Console.Write("Voer een getal in: ");
                int input = int.Parse(Console.ReadLine()); //Het getal dat de gebruiker ingevuld heeft

                if (input < 1) //Einde van de while loop, dus einde programma
                    break;

                int factor = 2; //De factor waardoor gedeeld gaat worden
                while (input > 1) //Blijf delen zolang het getal groter is dan 1
                {
                    if (input % factor == 0) //Kijk of de deling mogelijk is zonder rest
                    {
                        Console.Write(factor + " ");

                        input = input / factor; //Voer de deling uit
                    } 
                    else
                        factor++; //Als de factor nu geen deling geeft met rest 0 wordt deze verhoogd.
                }

                Console.WriteLine(); //Ga naar de volgende regel wanneer de berekening voltooid is
            }

            Console.WriteLine();
            Console.WriteLine("Einde programma");
            Console.ReadLine();
        }
    }
}
