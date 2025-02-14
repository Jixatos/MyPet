using MyPet.Models;
using MyPet.Service;
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
        private readonly Menu Menu;
        private readonly Mensagens Mensagens;

        private readonly PokeAPIService Service = new PokeAPIService();
        private bool playing = true;
        private string[] pokemonsNames= ["bulbasaur", "charmander", "squirtle", "torchic"];

        public Game()
        {
            Menu = new Menu();
            Mensagens = new Mensagens();
        }
        public void Start()
        {
            Mensagens.Welcome();

            Player player = new Player();

            player.Name = Menu.ReadUserInput("What's your name?");
            
            while (playing)
            {
                Menu.Options(player.Name);
                int input = Menu.ReadUserInputToInt();

                switch(input)
                {
                    case 1:
                        Menu.Especies(pokemonsNames);
                        player.Pets.Add(ChosenPet(player, pokemonsNames));
                        GoBackOptions();
                        break;
                    case 2:
                        Menu.ShowPlayerPokemons(player.Pets);
                        GoBackOptions();
                        break;
                    case 0:
                        Mensagens.Goodbye();
                        Console.Clear();
                        playing = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }

        public Pet ChosenPet(Player player, string[] pokemonsNames)
        {
            int num = Menu.ReadUserInputToInt();

            Pet pet = Service.GetPokemonByName(pokemonsNames[num-1]);

            if (pet == null)
            {
                Console.WriteLine("Pet not found!");
            }

            return pet;
        }

        public void GoBackOptions()
        {
            string input;
            do
            {
                Console.WriteLine("\nGo back to Options?");
                input = Menu.ReadUserInput();
                switch (input.ToUpper())
                {
                    case "YES":
                        input = "YES";
                        break;
                    case "NO":
                        input = "NO";
                        break;
                    default:
                        Console.WriteLine("Respond with a Yes or No");
                        break;
                }              
            } while (input != "YES");

        }
    }
}
