using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    public class StemSysteem
    {
        private static StemSysteem instance;

        public static StemSysteem Instance
        {
            get
            {
                if (instance == null)
                    instance = new StemSysteem();

                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private List<string> tegenStemmers = new List<string>();
        private List<string> voorStemmers = new List<string>();

        public void Stem(string stemCode, bool voorStemmer)
        {
            if (!StemCodeGebruikt(stemCode))
            {
                if (voorStemmer)
                {
                    voorStemmers.Add(stemCode);
                    Console.WriteLine(stemCode + " is toegevoegd aan de voorstemmers");
                }
                else
                {
                    tegenStemmers.Add(stemCode);
                    Console.WriteLine(stemCode + " is toegevoegd aan de tegenstemmers");
                }
            }
            else
                Console.WriteLine(stemCode + " is al gebruikt");
        }

        public bool StemCodeGebruikt(string stemCode)
        {
            if (tegenStemmers.Contains(stemCode) || voorStemmers.Contains(stemCode))
                return true;

            return false;
        }
    }
}