using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht4___Lingo
{
    public class LingoGame
    {
        public string lingoWord;
        public string playerWord;
        public Enums.LetterState[] letterResults;

        public void Init(string lingoWord)
        {
            this.lingoWord = lingoWord;
            letterResults = new Enums.LetterState[lingoWord.Length];
        } //Initialize the local values

        public bool GuessedWord()
        {
            return playerWord == lingoWord;
        } //Check if the player has guessed the word

        public void CheckWord(string playerWord)
        {
            this.playerWord = playerWord;

            List<char> refLetters = new List<char>();

            for(int i = 0; i < lingoWord.Length; i++)
            {
                if (playerWord[i] != lingoWord[i])
                    refLetters.Add(lingoWord[i]);
            }

            for(int i = 0; i < playerWord.Length; i++)
            {
                if (playerWord[i] == lingoWord[i])
                    letterResults[i] = Enums.LetterState.Correct;
                else
                {
                    if (refLetters.Contains(playerWord[i]))
                    {
                        letterResults[i] = Enums.LetterState.WrongPos;
                        refLetters.Remove(playerWord[i]);
                    }
                    else
                        letterResults[i] = Enums.LetterState.Incorrect;
                }
            }
        } //Check the word for matching letters
    }
}
