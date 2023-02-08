using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Wordle.Repositories.Interfaces;

namespace Wordle.Repositories.Implementations
{
    public class WordGeneratorRepository : IWordGeneratorRepository
    {
        public List<string> GenerateWords(string textFileOutput)
        {
            // Creates a list of words
            List<string> words = new List<string>();

            // Extracts a word from a txt file and adds it to the list
            using (StreamReader sr = new StreamReader(textFileOutput))
            {
                while (!sr.EndOfStream)
                {
                    string word = sr.ReadLine();
                    words.Add(word.Trim());
                }
            }

            return words;
        }

        public string SelectRandomWord(List<string> words)
        {
            // Pick a random word from the list
            Random random = new Random();
            int randomIndex = random.Next(words.Count);
            return words[randomIndex];
        }
    }
}
