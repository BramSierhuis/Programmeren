using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 60;

            Console.Write("Geef je naam: ");
            string naam = Console.ReadLine(); 
            
            Console.Write("Geef je aantal vrijstelling EC's: ");
            int vrijstellingEC = int.Parse(Console.ReadLine());
            
            Console.Write("Geef jouw totaal aantal EC's van jaar1: ");
            int behaaldeEC = int.Parse(Console.ReadLine());

            int resterendeEC = MAX - vrijstellingEC;
            double benodigdeEC = resterendeEC * 0.75 + vrijstellingEC;

            Console.WriteLine("(Vereist aantal EC's om naar jaar 2 te mogen: {0})", benodigdeEC);
            Console.WriteLine();

            if(behaaldeEC >= benodigdeEC)
                Console.WriteLine("{0}, je hebt genoeg EC's gehaald om naar jaar 2 te mogen", naam);
            else
                Console.WriteLine("{0}, je hebt (nog) niet genoeg EC's gehaald om naar jaar 2 te mogen", naam);

            Console.WriteLine();
            Console.WriteLine("Einde programma");
            Console.ReadKey();
        }
    }
}
