using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle.Repositories.Interfaces
{
    public interface IGameRepository
    {
        bool PlayGame(string selectedWord, string playerGuess, List<string> words);

        void PrintAlphabetWithColors();
    }
}
