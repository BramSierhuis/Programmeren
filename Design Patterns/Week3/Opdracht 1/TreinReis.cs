using Opdracht_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opracht_1
{
    public class TreinReis : ITreinReis
    {
        private List<TreinStation> stations;
        private List<ITreinDisplay> displays;

        private int huidigStation;
        private bool isOnReturnHome = false;

        public TreinReis()
        {
            stations = new List<TreinStation>();
            displays = new List<ITreinDisplay>();

            stations.Add(new TreinStation("Amsterdam", "2", new DateTime(2020, 5, 7, 15, 0, 0), new DateTime(2020, 5, 7, 15, 20, 0)));
            stations.Add(new TreinStation("Heemskerk", "4", new DateTime(2020, 5, 7, 14, 0, 0), new DateTime(2020, 5, 7, 14, 15, 0)));
            stations.Add(new TreinStation("Beverwijk", "1", new DateTime(2020, 5, 7, 13, 0, 0), new DateTime(2020, 5, 7, 13, 10, 0)));
            stations.Add(new TreinStation("Uitgeest", "6", new DateTime(2020, 5, 7, 12, 0, 0), new DateTime(2020, 5, 7, 12, 5, 0)));

            huidigStation = 0;
        }

        public void AddObserver(ITreinDisplay display)
        {
            displays.Add(display);
        }

        public void RemoveObserver(ITreinDisplay display)
        {
            displays.Remove(display);
        }

        private void NotifyObservers()
        {
            foreach (ITreinDisplay display in displays)
            {
                if(isOnReturnHome)
                    display.Update(stations[huidigStation].Naam, stations[huidigStation - 1].Naam, stations[huidigStation - 1].AankomstSpoor, stations[huidigStation - 1].AankomstTijd);
                else
                    display.Update(stations[huidigStation].Naam, stations[huidigStation + 1].Naam, stations[huidigStation + 1].AankomstSpoor, stations[huidigStation + 1].AankomstTijd);
            }
        }

        public void VolgendStation()
        {
            if (isOnReturnHome)
            {
                if (huidigStation == 0)
                    isOnReturnHome = false;
            }
            else
            {
                if (huidigStation + 1 == stations.Count)
                    isOnReturnHome = true;
            }

            NotifyObservers();

            if (isOnReturnHome)
                huidigStation--;
            else
                huidigStation++;
        }

        public void NieuwDisplay()
        {
            TreinDisplay display = new TreinDisplay(this);

            display.Text = "TreinDisplay #" + displays.Count;
            display.Show();
        }
    }
}
