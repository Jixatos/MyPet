using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MyPet.Models;
using MyPet.View;
using RestSharp;

namespace MyPet.Service
{
    internal class PokeAPIService
    {
        private readonly RestClient Client;

        public PokeAPIService()
        {
            Client = new RestClient("https://pokeapi.co/api/v2/");
        }

        public Pet? GetPokemonByName(string pokemonName)
        {
            
            RestRequest request = new RestRequest($"pokemon/{pokemonName}", Method.Get);
            var response = Client.Execute(request);

            if(!response.IsSuccessful)
            {
                return null;
            }

            var json = response.Content.ToString();

            var myPet = JsonSerializer.Deserialize<Pet>(json);

            return myPet;
        }
    }
}
