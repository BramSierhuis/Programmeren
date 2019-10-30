using System;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 10; //Hoe vaak er getallen gegenereerd worden

            Random rnd = new Random(); //De random die gebruikt gaat worden voor het genereren van random getallen

            for(int i = 0; i < SIZE; i++) //Voer de berekening SIZE keer uit
            {
                int getal1 = rnd.Next(1, 51); //Geef de getallen de random waardes
                int getal2 = rnd.Next(1, 6);
                
                int rest; //De restwaarde van de deling
                int quotient = IntegerDeling(getal1, getal2, out rest); //De quotient van de deling

                Console.WriteLine("{0} / {1} = {2} ({3})", getal1, getal2, quotient, rest); //Toon de berekende waardes
            }

            Console.WriteLine();
            Console.WriteLine("Einde programma");
            Console.ReadLine();
        }

        static int IntegerDeling(int getal1, int getal2, out int rest)
        {
            int quotient = 0;

            while(getal1 - getal2 >= 0) //Blijf aftrekken zolang de uitkomst positief is
            {
                getal1 -= getal2; //Verhoog de quotient met elke aftrekking
                quotient++;
            }

            rest = getal1; //De restwaarde is wat er van getal1 overblijft
            return quotient; //Retourneer de quotient 
        }
    }
}
