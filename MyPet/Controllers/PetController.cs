using MyPet.Data.Models;
using MyPet.Service;
using MyPet.View;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            Pet pet = _aPIService.GetPokemonByName(petName);

            if (pet == null)
            {
                Console.WriteLine($"Error: Pokémon '{petName}' not found.");
                return false;
            }

            _petView.PetInfos(pet);
            return true;
        }

        public void ShowPetStatus(Pet pet)
        {
            _petView.PetInfos(pet);

            Console.WriteLine("\nState:");
            _petView.HumorLevel(pet);
            _petView.FatigueLevel(pet);
            _petView.HungryLevel(pet);
            Thread.Sleep(3000);
        }
        public void Feed(Pet pet)
        {
            _petView.FeedMessage(pet.Name);
            pet.Eat();
            Thread.Sleep(3000);
        }
        public void PlayWith(Pet pet)
        {
            _petView.PlayMessage(pet.Name);
            pet.Play();
            Thread.Sleep(3000);
        }
        public void PutToSleep(Pet pet)
        {
            _petView.SleepMessage(pet.Name);
            pet.Sleep();
            Thread.Sleep(5000);
        }
    }
}
