using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class CD : BookStoreItem
    {
        public string Artist { get; set; }

        public CD(string artist, string title, float price, int numberOfItems) : base(title, price, numberOfItems)
        {
            Artist = artist;
        }

        public override string ToString()
        {
            return string.Format("[CD] {0} - {1}, {2} ({3}x)", Artist, Title, Price.ToString("0.00"), NumberOfItems);
        }
    }
}
