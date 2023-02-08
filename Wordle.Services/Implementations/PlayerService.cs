
using System;
using Wordle.Repositories.Interfaces;
using Wordle.Services.Interfaces;

namespace Wordle.Services.Implementations
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        
        public string GetGuess()
        {
            return _playerRepository.GetGuess().ToUpper();
        }
    }
}
