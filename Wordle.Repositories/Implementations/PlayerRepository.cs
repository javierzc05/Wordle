using System;
using Wordle.Repositories.Interfaces;

namespace Wordle.Repositories.Implementations
{
    public class PlayerRepository : IPlayerRepository
    {
        // Sets the length of the word to guess. In the rules it says 5
        private readonly int desiredLength = 5;

        public string GetGuess()
        {           
            // Get the player's guess if the length of the word is 5, otherwise keep guessing
            Console.WriteLine("Enter a guess of {0} characters long: ", desiredLength);
            string playerGuess = Console.ReadLine();
            while (playerGuess.Length != desiredLength)
            {
                Console.WriteLine("Invalid input. Enter a guess of {0} characters long: ", desiredLength);
                playerGuess = Console.ReadLine();
            }
            return playerGuess;
        }
    }
}
