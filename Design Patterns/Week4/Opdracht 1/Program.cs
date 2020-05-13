using System;
using System.Collections.Generic;

namespace Opdracht_1
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
            List<Character> characters = new List<Character>();

            characters.Add(new Queen());
            characters.Add(new Troll());
            characters.Add(new King());
            characters.Add(new Knight());

            foreach (Character character in characters)
                character.Fight();

            Console.WriteLine();

            characters[3].Weapon = new AxeBehaviour();
            foreach (Character character in characters)
                character.Fight();

            Console.ReadKey();
        }
    }
}
