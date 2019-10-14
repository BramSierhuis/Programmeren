using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a price: ");
            float price = float.Parse(Console.ReadLine());
            float btw = CalculateBTW(price);
            float total = btw + price;

            Console.WriteLine("Price: {0}, VAT: {1}, Total: {2}", price, btw.ToString("0.00"), total.ToString("0.00"));
        }

        static float CalculateBTW(float price)
        {
            float btw = price * 0.21f;
            return btw;
        }
    }
}
