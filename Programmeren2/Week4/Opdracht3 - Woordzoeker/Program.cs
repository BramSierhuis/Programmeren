using System;
using System.IO;

namespace Opdracht3___Woordzoeker
{
    class Program
    {
        const string PATH = "../../../";

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadKey();
        }

        void Start()
        {
            Console.Write("Enter a word to search for: ");
            string input = Console.ReadLine();

            Console.WriteLine();
            int aantal = ZoekWoordInBestand("tweets.txt", input);
            
            Console.WriteLine();
            Console.WriteLine("Het woord is in {0} zinnen voorgekomen.", aantal);
        }

        void ToonWoordInRegel(string regel, string woord)
        {
            string[] woorden = regel.Split(' ');

            foreach(string woordInRegel in woorden)
            {
                if (woordInRegel.ToUpper() == woord.ToUpper())
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(woordInRegel + ' ');
            }

            Console.WriteLine();
        }

        bool ZitWoordInRegel(string regel, string woord)
        {
            if (regel.ToUpper().Contains(woord.ToUpper()))
                return true;

            return false;
        }

        int ZoekWoordInBestand(string name, string woord)
        {
            int counter = 0;
            StreamReader sr = new StreamReader(PATH + name);

            while (!sr.EndOfStream)
            {
                string regel = sr.ReadLine();

                if(ZitWoordInRegel(regel, woord))
                {  
                    counter++;
                    ToonWoordInRegel(regel, woord);
                }
            }

            sr.Close();

            return counter;
        }
    }
}