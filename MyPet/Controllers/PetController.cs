using MyPet.Models;
using MyPet.Service;
using MyPet.View;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyPet.Controllers
{
    class PetController
    {
        private readonly PokeAPIService _aPIService;
        private readonly PetView _petView;

        public PetController(PokeAPIService aPIService, PetView petView)
        {
            _aPIService = aPIService;
            _petView = petView;
        }

        public bool ReadPetInfo(string petName)
        {
            try
            {
                Pet pet = _aPIService.GetPokemonByName(petName);

                _petView.PetInfos(pet);
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
