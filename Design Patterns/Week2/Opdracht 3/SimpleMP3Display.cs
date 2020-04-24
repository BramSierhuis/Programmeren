using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_3
{
    public class SimpleMP3Display : IObserver
    {
        private IObservable MP3Player;

        public SimpleMP3Display(IObservable MP3Player)
        {
            this.MP3Player = MP3Player;
            MP3Player.AddObserver(this);
        }

        public void Update(Song song)
        {
            Console.WriteLine("SimpleDisplay: {0} - '{1}'", song.Artist, song.Title);
        }
    }
}
