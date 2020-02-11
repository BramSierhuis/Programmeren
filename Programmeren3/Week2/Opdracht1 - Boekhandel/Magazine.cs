using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1___Boekhandel
{
    public class Magazine : Item
    {
        Enums.Days releaseDay;

        public Magazine(string title, Enums.Days releaseDay, double price) : base(title, price)
        {
            this.releaseDay = releaseDay;
        }

        public override void Print()
        {
            Console.WriteLine("[Magazine] '{0}' - release day: {1}, ${2}", title, releaseDay, price.ToString("0.00"));
        }
    }
}
