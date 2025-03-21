using MyPet.Models;
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
        private readonly Messages _messages;

        public PlayerController(PokeAPIService apiService, Player player, Messages messages)
        {
            _aPIService = apiService;
            _player = player;
            _messages = messages;
        }
            
        public bool SavePokemonChosen(string petName)
        {
            try
            {
                Pet pet = _aPIService.GetPokemonByName(petName);

                _player.Pets.Add(pet);
                _messages.AdoptCongrats(pet.Name);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Inespered Error: '{petName}': {ex.Message}");
                return false;
            }
        }
    }
}
