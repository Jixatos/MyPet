using MyPet.Data.Models;
using MyPet.Service;
using MyPet.View;
using MyPet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Controllers
{
    class MenuController
    {
        private readonly EspeciesService _especiesService;
        private readonly MenuView _menuView;
        private readonly PlayerController _playerController;
        private readonly PetController _petController;
        private readonly Messages _messages;
        public MenuController(EspeciesService especiesService,
                              MenuView menuView,
                              PlayerController playerController,
                              PetController petController,
                              Messages message)
        {
            _especiesService = especiesService;
            _menuView = menuView;
            _playerController = playerController;
            _petController = petController;
            _messages = message;
        }

        public void Start(Player player)
        {
            _menuView.Options(player.Name);

            int option = ReadMenuOption(0, 2);

            switch (option)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Adoption();
                    break;
                case 2:
                    Adopted(player.Pets);
                    break;
            }
        }

        public void Adoption()
        {
            string petName = SelectPetToAdopt();

            PetInfoOptions(petName);
        }

        public string SelectPetToAdopt()
        {
            List<string> especies = _especiesService.GetEspeciesNames();
            _menuView.ShowEspecies(especies);

            int index = ReadMenuOption(max: especies.Count);

            return especies[index - 1];
        }

        public void PetInfoOptions(string petName)
        {
            bool menu = false;
            do
            {
                _menuView.PetInfoOptions(petName);

                int input = ReadMenuOption(0, 2);

                switch (input)
                {
                    case 0:
                        menu = true;
                        break;
                    case 1:
                        _petController.ReadPetInfo(petName);
                        menu = ConfirmOptions("Do you want to go back?");
                        break;
                    case 2:
                        menu = _playerController.SavePokemonChosen(petName);
                        break;
                }
            } while (!menu);
        }

        public void Adopted(List<Pet> pets)
        {
            Pet? pet = SelectPlayerPet(pets);

            if (pet == null)
            {
                return;
            }
            Interactions(pet);
        }

        public Pet? SelectPlayerPet(List<Pet> pets)
        {
            _playerController.ShowPlayerPets(pets);

            if (!_playerController.PlayerHasPets(pets))
            {
                return null;
            }

            int index = ReadMenuOption(min: 1, max:pets.Count) - 1;

            return pets[index];
        }

        public void Interactions(Pet pet)
        {
            bool menu = true;
            do
            {
                _menuView.Interactions(pet.Name);
                int option = ReadMenuOption(0, 4);
                switch (option)
                {
                    case 0:
                        menu = false;
                        break;
                    case 1:
                        _petController.ShowPetStatus(pet);
                        break;
                    case 2:
                        _petController.Feed(pet);
                        break;
                    case 3:
                        _petController.PlayWith(pet);
                        break;
                    case 4:
                        _petController.PutToSleep(pet);
                        break;
                }
            } while (menu);
        }

        public string ReadUserName()
        {
            string input;
            do
            {
                Console.WriteLine("What's your name?");

                input = Console.ReadLine()?.Trim();

                if (!string.IsNullOrEmpty(input))
                {
                    input = ConfirmOptions($"Do you want to be called by {input}?") ? input : string.Empty;
                }
                else
                {
                    Console.WriteLine("Enter a valid name");
                }

            } while (string.IsNullOrEmpty(input));
            return input;
        }

        public bool ConfirmOptions(string message)
        {
            int input;
            do
            {
                Console.WriteLine($"\n{message}");
                Console.WriteLine("1 - Yes\n2 - No");
                input = ReadMenuOption();
                switch (input)
                {
                    case 1:
                        return true;
                    case 2:
                        return false;
                    default:
                        Console.WriteLine("Respond with 1 for Yes or 2 for No");
                        break;
                }
            } while (input != 1 || input != 2);
            return false;
        }

        public int ReadMenuOption(int min = 1, int max = 2)
        {
            int value;
            do
            {
                string input = Console.ReadLine().Trim();

                if (int.TryParse(input, out value))
                {
                    if (UserInputIsInRange(min, max, value))
                    {
                        return value;
                    }
                }

                Console.WriteLine("Invalid entry. Please try again.");

            } while (true);
        }

        public bool UserInputIsInRange(int min, int max, int input)
        {
            return input >= min && input <= max;
        }
    }
}

