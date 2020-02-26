using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1___Boekhandel
{
    public class Magazine : Item
    {
        Enums.Days ReleaseDay { get; set; }

        public Magazine(string title, Enums.Days releaseDay, double price) : base(title, price)
        {
            ReleaseDay = releaseDay;
        }

        public override void Print()
        {
            Console.WriteLine("[Magazine] '{0}' - release day: {1}, ${2} ({3}x)", Title, ReleaseDay, Price.ToString("0.00"), Count);
        }
    }
}
