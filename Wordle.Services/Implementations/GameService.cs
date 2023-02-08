
using System;
using System.Collections.Generic;
using Wordle.Repositories.Interfaces;
using Wordle.Services.Interfaces;

namespace Wordle.Services.Implementations
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }
        
        public void PrintAlphabetWithColors()
        {
            _gameRepository.PrintAlphabetWithColors();
        }

        public bool PlayGame(string selectedWord, string playerGuess, List<string> words)
        {
            return _gameRepository.PlayGame(selectedWord, playerGuess, words);
        }
    }
}
