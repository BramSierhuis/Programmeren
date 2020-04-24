using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_3
{
    public class MP3Player : IObservable
    {
        private List<IObserver> displays = new List<IObserver>();
        private List<Song> songs = new List<Song>();

        public Song CurrentSong { get; private set; }

        public MP3Player()
        {
            songs.Add(new Song("Wish you were here", "Pink Floyd", 192));
            songs.Add(new Song("Dazed and Confused", "Led Zeppelin", 240));
            songs.Add(new Song("Billionaire", "Bruno Mars", 213));
        }

        public void AddObserver(IObserver display)
        {
            displays.Add(display);
        }

        public void NextSong()
        {
            int index = songs.IndexOf(CurrentSong);

            if (index == -1)
                CurrentSong = songs[0]; //Start with the first song
            else if (index == songs.Count - 1)
                CurrentSong = songs[0]; //Start again from the beginning
            else
                CurrentSong = songs[index + 1];

            foreach (IObserver display in displays)
                display.Update(CurrentSong);
        }

        public void RemoveObserver(IObserver display)
        {
            displays.Remove(display);
        }
    }
}
