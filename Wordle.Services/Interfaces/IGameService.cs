using System;
using System.Collections.Generic;

namespace Wordle.Services.Interfaces
{
    public interface IGameService
    {
        bool PlayGame(string selectedWord, string playerGuess, List<string> words);

        void PrintAlphabetWithColors();
    }
}
