using MyPet.Models;
using MyPet.Service;
using MyPet.View;
using MyPet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Controllers
{
    internal class Game
    {
        private readonly Menu _menu;
        private readonly Messages _message;
        private readonly PetView _petView;
        private readonly PlayerView _playerView;

        private readonly PokeAPIService Service = new PokeAPIService();
        private string[] pokemonsNames = ["bulbasaur", "charmander", "squirtle", "torchic"];
        private bool playing = true;

        public Game()
        {
            _menu = new Menu();
            _message = new Messages();
            _petView = new PetView();
            _playerView = new PlayerView();
        }
        public void Start()
        {
            _message.Welcome();

            Player player = new Player();

            player.Name = _menu.ReadUserInput("What's your name?");

            while (playing)
            {
                _menu.Options(player.Name);
                int? input = _menu.UserOptionsConfirm(0, 2);

                switch (input)
                {
                    case 1:
                        _petView.ShowEspecies(pokemonsNames);
                        ChoosePet(player, pokemonsNames);
                        _menu.GoBackOptions();
                        break;
                    case 2:
                        _playerView.ShowPlayerPokemons(player.Pets);
                        _menu.GoBackOptions();
                        break;
                    case 0:
                        _message.Goodbye();
                        Console.Clear();
                        playing = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }

        public void ChoosePet(Player player, string[] pokemonsNames)
        {
            try
            {
                int? num = _menu.UserOptionsConfirm(1, 4);

                if (num == null)
                {
                    return;
                }

                Pet pet = Service.GetPokemonByName(pokemonsNames[(int)(num - 1)]);

                if (pet == null)
                {
                    Console.WriteLine("Error: Could not retrive the pokeom from the API");
                    return;
                }

                player.Pets.Add(pet);
                _petView.PetInfos(pet);
                _message.AdoptCongrats(player.Name, pet.Name);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Choose a valid number");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected Error: {e.Message}");
            }
        }
    }
}
