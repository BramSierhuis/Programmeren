using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_3
{
    public class FancyMP3Display : IObserver
    {
        private IObservable MP3Player;

        public FancyMP3Display(IObservable MP3Player)
        {
            this.MP3Player = MP3Player;
            MP3Player.AddObserver(this);
        }

        public void Update(Song song)
        {
            string duration = TimeSpan.FromSeconds(song.Duration).ToString(@"mm\:ss");

            Console.WriteLine("FancyDisplay: '{0}', by {1} ({2})", song.Title, song.Artist, duration);
        }
    }
}
