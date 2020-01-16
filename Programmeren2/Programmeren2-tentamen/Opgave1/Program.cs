using System;

namespace Opgave1
{
    class Program
    {
        const string ALFABET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789 ,;.!?";

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadKey();
        }

        void Start()
        {
            Console.Write("Geef het bericht: ");
            string bericht = Console.ReadLine();
            string sleutel = MaakGeheimeSleutel(bericht.Length);

            Console.WriteLine("De geheime sleutel: " + sleutel);

            try
            {
                string versleuteld = OneTimePad(bericht, sleutel);
                Console.WriteLine("Versleuteld bericht: " + versleuteld);
            }
            catch (Exception e)
            {
                Console.WriteLine("Fout opgetreden tijdens het versleutelen: " + e.Message);
            }
        }

        string MaakGeheimeSleutel(int lengte)
        {
            Random random = new Random();
            string sleutel = "";

            for (int i = 0; i < lengte; i++)
            {
                sleutel += ALFABET[random.Next(0, ALFABET.Length)];
            }

            return sleutel;
        }

        string OneTimePad(string bericht, string sleutel)
        {
            string resultaat = "";

            for(int i = 0; i < bericht.Length; i++)
            {
                int berichtPos = ALFABET.IndexOf(bericht[i]);
                int sleutelPos = ALFABET.IndexOf(sleutel[i]);

                if (berichtPos == -1)
                    throw new Exception("karakter " + bericht[i] + " komt niet voor in het gebruikte alfabet.");

                int index = (berichtPos + sleutelPos) % ALFABET.Length;

                resultaat += ALFABET[index];
            }

            return resultaat;
        }
    }
}
