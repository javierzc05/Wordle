using System;
using System.Collections.Generic;
using Wordle.Repositories.Implementations;
using Wordle.Repositories.Interfaces;
using Wordle.Services.Implementations;

namespace Wordle
{
    internal class Program
    {
        public static WordGeneratorService wordGenerator { get; private set; }
        private static PlayerService player;
        private static GameService gameService;

        static void Main(string[] args)
        {
            // In case of creating an API you'll prefer to use dependency injection
            wordGenerator = new WordGeneratorService(new WordGeneratorRepository());
            player = new PlayerService(new PlayerRepository());
            gameService = new GameService(new GameRepository());

            /* 
             * In this case I assume there is a dictionary of valid words, so I downloaded a text full of english Wordle words
             * then I added them into another text file called "wordsToPlay.txt" that's the one that is being used to play         
            */
            // Set up a list of words to be used in the game
            List<string> words = wordGenerator.GenerateWords("wordsToPlay.txt");

            // Pick a random word from the list
            string selectedWord = wordGenerator.SelectRandomWord(words);

            int tries = 1;
            bool isGameFinished = false;
            // Keep playing until the game is finished or the tries are over 6
            while (tries <= 6 && !isGameFinished)
            {
                // Prints the alphabet with the colors to indicate the player's progress
                gameService.PrintAlphabetWithColors();
                Console.WriteLine("Turn No.{0}: ", tries);
                Console.WriteLine();
                // Gets the player guess which needs to be a valid word in the "wordsToPlay.txt" file
                string playerGuess = player.GetGuess();
                Console.WriteLine("The entered word was: " + playerGuess);

                // Checks if the word is valid (Wordle text file)
                if (!words.Contains(playerGuess))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid word...");
                    Console.WriteLine();
                }
                else
                {
                    tries++;
                    isGameFinished = gameService.PlayGame(selectedWord, playerGuess, words);
                   
                }
            }
        }
    }
}
