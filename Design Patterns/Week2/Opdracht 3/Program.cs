using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }

        void Start()
        {
            // maak een MP3 player aan
            IObservable player = new MP3Player();

            // maak de displays aan
            IObserver mp3Display1 = new SimpleMP3Display(player);
            IObserver mp3Display2 = new FancyMP3Display(player);

            // zet player op een nieuw nummer
            // (aangezien er geen hardware is, doen we dat hier...)
            player.NextSong();
            Console.WriteLine();

            player.NextSong();
            Console.WriteLine();            
            
            player.NextSong();
            Console.WriteLine(); 
            
            player.NextSong();
            Console.WriteLine();

            player.NextSong();
        }
    }
}
