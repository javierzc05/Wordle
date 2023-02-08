using System;
using System.Collections.Generic;

namespace Wordle.Repositories.Interfaces
{
    public interface IWordGeneratorRepository
    {
        List<string> GenerateWords(string textFileOutput);

        string SelectRandomWord(List<string> words);

    }
}
