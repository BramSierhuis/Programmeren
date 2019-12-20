using System;

namespace Opdracht4___Lingo
{
    class Program
    {
        const int WORDLENGTH = 5;
        const int ATTEMPTS = 5;

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadKey();
        }

        void Start()
        {
            string[] words = ReadWords();
            string lingoWord = ChooseWord(words);
            LingoGame lingoGame = new LingoGame();

            lingoGame.Init(lingoWord);

            PlayLingo(lingoGame);
        }

        void PlayLingo(LingoGame lingoGame)
        {
            int attemptsLeft = ATTEMPTS;

            while (attemptsLeft > 0 && !lingoGame.GuessedWord())
            {
                string playerWord = ReadPlayerWord(WORDLENGTH);

                lingoGame.CheckWord(playerWord);
                DisplayResult(lingoGame);

                attemptsLeft--;
            }   
            
            if(lingoGame.GuessedWord())
                Console.WriteLine("Congrats!");
            else
                Console.WriteLine("You loose!!!");
        } //Play a game of lingo

        string[] ReadWords() //Get a string[] of all the possible words
        {
            string[] words = { "young", "funny", "spike", "joker" };

            return words;
        }

        string ChooseWord(string[] words)
        {
            int size = words.Length;
            Random rnd = new Random();

            return words[rnd.Next(0, size)];
        } //Pick a random word from the string[]

        string ReadPlayerWord(int wordlength)
        {
            string word;
            do
            {
                Console.Write("Enter your guess: ");
                word = Console.ReadLine();
            }
            while (word.Length != wordlength);

            return word;
        } //Ask the player to enter a word

        void DisplayResult(LingoGame lingoGame) //Show what letters the player guessed right
        {
            for(int i = 0; i < WORDLENGTH; i++)
            {
                if (lingoGame.letterResults[i] == Enums.LetterState.Correct)
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                else if (lingoGame.letterResults[i] == Enums.LetterState.WrongPos)
                    Console.BackgroundColor = ConsoleColor.DarkYellow;

                Console.Write(lingoGame.playerWord[i]);

                Console.ResetColor();
            }

            Console.WriteLine();
        }
    }
}
