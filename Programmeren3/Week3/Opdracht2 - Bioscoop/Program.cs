using System;

namespace Opdracht2___Bioscoop
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
            try
            {
                Klant messi = new Klant("Lionel Messi", Convert.ToDateTime("06/24/1987"));
                Klant piet = new Klant("Piet Paulusma", Convert.ToDateTime("12/15/1956"));

                messi.PrintKlant();
                Console.WriteLine();
                piet.PrintKlant();
                Console.WriteLine();

                Reservering pietsReservering = new Reservering(piet);
                Reservering messisReservering = new Reservering(messi);

                Kaartje kaartje1 = new Kaartje("Test1", 1, Convert.ToDateTime("12/15/1956 22:00:00"), 6, 10.50);
                Kaartje kaartje2 = new Kaartje("Test2", 2, Convert.ToDateTime("12/15/1956 22:00:00"), 16, 10.50);
                Kaartje kaartje3 = new Kaartje("Test3", 3, DateTime.MinValue, 12, 10.50);

                pietsReservering.Kaartjes.Add(kaartje1);
                pietsReservering.Kaartjes.Add(kaartje2);
                pietsReservering.Kaartjes.Add(kaartje3);

                Console.WriteLine("Totaalprijs: " + pietsReservering.TotaalPrijs.ToString("0.00"));
                Console.WriteLine();

                Kaartje kaartje5 = new Kaartje("Test1", 1, Convert.ToDateTime("12/15/1956 22:00:00"), 6, 10.50);
                Kaartje kaartje6 = new Kaartje("Test2", 2, Convert.ToDateTime("12/15/1956 22:00:00"), 16, 10.50);
                Kaartje kaartje7 = new Kaartje("Test3", 3, DateTime.MinValue, 12, 10.50);

                messisReservering.Kaartjes.Add(kaartje5);
                messisReservering.Kaartjes.Add(kaartje6);
                messisReservering.Kaartjes.Add(kaartje7);

                Console.WriteLine("Totaalprijs: " + messisReservering.TotaalPrijs.ToString("0.00"));

             }
             catch (Exception e)
             {
                 Console.WriteLine("Error: " + e.Message);
             }            
        }
    }
}
