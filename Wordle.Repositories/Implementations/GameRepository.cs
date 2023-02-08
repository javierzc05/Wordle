using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Repositories.Interfaces;

namespace Wordle.Repositories.Implementations
{
    public class GameRepository : IGameRepository
    {
        private Dictionary<char, ConsoleColor> alphabetMap = new Dictionary<char, ConsoleColor>();
        
        public GameRepository()
        {
            // Creates a dictionary of letters with a default color
            for (int i = 0; i < 26; i++)
            {
                alphabetMap.Add((char)('A' + i), ConsoleColor.Gray);
            }

        }

        public void PrintAlphabetWithColors()
        {
            // Loop through the alphabet to print each letter with the corresponding color
            Console.WriteLine();
            foreach (var letter in alphabetMap)
            {
                Console.ForegroundColor = letter.Value;
                Console.Write(letter.Key + " ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        public bool PlayGame(string selectedWord, string playerGuess, List<string> words)
        {
            bool result = false;

            // Check if the player's guess is correct
            if (playerGuess == selectedWord)
            {
                Console.WriteLine("\nCorrect! You Won!");
                System.Threading.Thread.Sleep(3000);
                result = true;
            }

            // Loop through each letter in the player's guess
            for (int i = 0; i < playerGuess.Length; i++)
            {
                char letter = playerGuess[i];

                // Check if the letter is in the selected word
                int indexInSelected = selectedWord.IndexOf(letter);
                if (indexInSelected != -1)
                {
                    // If the letter is in the correct position, change the text color to green
                    if (letter == selectedWord[i])
                    {
                        alphabetMap[letter] = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    // If the letter is in the selected word but not in the correct position, change the text color to yellow
                    else
                    {
                        alphabetMap[letter] = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(letter);
                    Console.ResetColor();
                }
                // If the letter is not in the selected word, keep the text color unchanged
                else
                {
                    Console.Write(letter);
                }
            }

            Console.WriteLine();
            return result;

        }
    }
}
