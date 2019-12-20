using System;
using System.Collections.Generic;
using System.IO;

namespace Opdracht3___Vertalen
{
    class Program
    {
        const string PATH = "../../../";

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadKey();
        }

        void Start()
        {
            Dictionary<string, string> dictionary = ReadWords("dictionary.csv");

            TranslateWords(dictionary);
        }

        Dictionary<string, string> ReadWords(string filename)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            StreamReader reader = new StreamReader(PATH + filename);

            while (!reader.EndOfStream)
            {
                string[] line = new string[2];
                line = reader.ReadLine().Split(';');

                dictionary.Add(line[0], line[1]);
            }

            reader.Close();

            return dictionary;
        }

        void TranslateWords(Dictionary<string, string> words)
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();

            while(input != "stop")
            {
                if (input == "listall")
                    ListAllWords(words);
                else if (words.ContainsKey(input))
                    Console.WriteLine("{0} => {1}", input, words[input]);
                else
                    Console.WriteLine("word {0} not found", input);

                Console.Write("Enter a word: ");
                input = Console.ReadLine();
            }
        }

        void ListAllWords(Dictionary<string, string> words)
        {
            foreach(KeyValuePair<string, string> pair in words)
            {
                Console.WriteLine("{0} => {1}", pair.Key, pair.Value);
            }
        }
    }
}
