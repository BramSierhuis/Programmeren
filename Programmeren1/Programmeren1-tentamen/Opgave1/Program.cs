using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 60; //Het maximaal aantal mogelijk haalbare EC's

            Console.Write("Geef je naam: ");
            string naam = Console.ReadLine(); //De naam van de student 
            
            Console.Write("Geef je aantal vrijstelling EC's: ");
            int vrijstellingEC = int.Parse(Console.ReadLine()); //Het aantal EC's waar de student een vrijstelling voor heeft
            
            Console.Write("Geef jouw totaal aantal EC's van jaar 1: ");
            int behaaldeEC = int.Parse(Console.ReadLine()); //Het aantal EC's dat de student dit jaar behaald heeft

            int resterendeEC = MAX - vrijstellingEC; //Op hoeveel EC's de 75% regel toegepast zal worden
            double benodigdeEC = resterendeEC * 0.75 + vrijstellingEC; //Het aantal EC's dat de student totaal moet hebben om over te gaan

            Console.WriteLine("(Vereist aantal EC's om naar jaar 2 te mogen: {0})", benodigdeEC);
            Console.WriteLine();

            if(behaaldeEC >= benodigdeEC) //Als de student meer of evenveel EC's behaald heeft als dat hij nodig heeft gaat hij over
                Console.WriteLine("{0}, je hebt genoeg EC's gehaald om naar jaar 2 te mogen", naam);
            else
                Console.WriteLine("{0}, je hebt (nog) niet genoeg EC's gehaald om naar jaar 2 te mogen", naam);

            Console.WriteLine();
            Console.WriteLine("Einde programma");
            Console.ReadKey();
        }
    }
}
