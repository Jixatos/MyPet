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

        public PlayerController(PokeAPIService apiService, Player player)
        {
            _aPIService = apiService;
            _player = player;
        }
        
        public void SavePokemonChosen(string petName)
        {
            var pet = _aPIService.GetPokemonByName(petName);

            if(pet == null)
            {
                Console.WriteLine("Error with the request on the API");
            }
            else
            {
                _player.Pets.Add(pet);
            }
        }
    }
}
