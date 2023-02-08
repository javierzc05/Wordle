using System.Collections.Generic;

namespace Wordle.Services.Interfaces
{
    public interface IWordGeneratorService
    {
        List<string> GenerateWords(string textFileOutput);

        string SelectRandomWord(List<string> words);

    }
}