using System;

namespace MyTools
{
    public class LeesTools
    {
        public static int LeesInt(string vraag)
        {
            Console.Write(vraag);
            int input = int.Parse(Console.ReadLine());

            return input;
        }

        public static string LeesString(string vraag)
        {
            Console.Write(vraag);
            string input = Console.ReadLine();

            return input;
        }

        public static int LeesInt(string vraag, int min, int max)
        {
            Console.Write(vraag);
            int input = int.Parse(Console.ReadLine());

            while (input < min || input > max)
            {
                Console.Write(vraag);
                input = int.Parse(Console.ReadLine());
            }

            return input;
        }
    }
}
