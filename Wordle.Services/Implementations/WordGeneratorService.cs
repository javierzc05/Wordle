
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Wordle.Repositories.Interfaces;
using Wordle.Services.Interfaces;

namespace Wordle.Services.Implementations
{
    public class WordGeneratorService : IWordGeneratorService
    {
        private readonly IWordGeneratorRepository _wordGeneratorRepository;

        public WordGeneratorService(IWordGeneratorRepository wordGeneratorRepository)
        {
            _wordGeneratorRepository = wordGeneratorRepository;
        }
        
        public List<string> GenerateWords(string textFileOutput)
        {
            try
            {
                return _wordGeneratorRepository.GenerateWords(textFileOutput);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string SelectRandomWord(List<string> words)
        {
            if (words.Count == 0)
            {
                throw new Exception("The words list is empty");
            }
            return _wordGeneratorRepository.SelectRandomWord(words);
        }
    }
}
