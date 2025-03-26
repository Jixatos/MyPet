using MyPet.Data.Models;
using MyPet.Service;
using MyPet.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Controllers
{
    class PlayerController
    {
        private readonly Player _player;
        private readonly PokeAPIService _aPIService;
        private readonly PlayerView _playerView;
        private readonly Messages _messages;

        public PlayerController(PokeAPIService apiService, Player player, PlayerView playerView, Messages messages)
        {
            _aPIService = apiService;
            _player = player;
            _playerView = playerView;
            _messages = messages;
        }

        public bool SavePokemonChosen(string petName)
        {
            try
            {
                Pet pet = _aPIService.GetPokemonByName(petName);

                _player.AdoptPet(pet);
                _messages.AdoptCongrats(petName);
                Thread.Sleep(2000);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: '{petName}': {ex.Message}");
                return false;
            }
        }

        public void ShowPlayerPets(List<Pet> pets)
        {
            if (PlayerHasPets(pets))
            {
                _playerView.ShowPlayerPets(pets);
                return;
            }
            _playerView.NoPets();
            Thread.Sleep(2000);
        }

        public bool PlayerHasPets(List<Pet> pets)
        {
            return pets.Count > 0 ? true : false;
        }

        public void NoPets()
        {
            _playerView.NoPets();
        }
    }
}
