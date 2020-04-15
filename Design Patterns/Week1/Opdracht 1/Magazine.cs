using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class Magazine : BookStoreItem
    {
        public DayOfWeek ReleaseDay { get; set; }

        public Magazine(DayOfWeek releaseDay, string title, float price, int numberOfItems) : base(title, price, numberOfItems)
        {
            ReleaseDay = releaseDay;
        }

        public override string ToString()
        {
            return string.Format("[Magazine] {0} - {1}, {2} ({3}x)", Title, ReleaseDay, Price.ToString("0.00"), NumberOfItems);
        }
    }
}
