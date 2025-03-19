using MyPet.Models;
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
        private readonly PetView _petView;

        public MenuController(EspeciesService especiesService,
                              MenuView menuView,
                              PetView petView,
                              Messages messages)
        {
            _especiesService = especiesService;
            _menuView = menuView;
            _petView = petView;
        }

        public string ReadUserName()
        {
            string input;
            do
            {
                Console.WriteLine("What's your name?");

                input = Console.ReadLine().Trim();

                input = ConfirmOptions($"Do you want to be called by {input}?") ? input : "";

            } while (!string.IsNullOrEmpty(input));
            return input;
        }

        public bool ConfirmOptions(string message)
        {
            int input;
            do
            {
                Console.WriteLine($"\n{message}");
                Console.WriteLine("1 - Yes\n2 - No");
                input = ReadUserInputNumeric();
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

        public void AdoptPetOption(string nome, Pet pet)
        {
            _menuView.AdoptOptions(nome);

            int input = ReadUserInputNumeric(0, 2);
            switch (input)
            {
                case 1:
                    _petView.PetInfos(pet);
                    break;
                default:
                    break;
            }
        }
        public void ChoosePetOption()
        {
            List<string> especies = _especiesService.GetEspeciesNames();
            _menuView.ShowEspecies(especies);

            int input = ReadUserInputNumeric(0, especies.Count);
        }

        public int ReadUserInputNumeric(int min = 1, int max = 2)
        {
            int value;
            do
            {
                string input = Console.ReadLine();

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
            return (input >= min || input <= max) ? true : false;
        }
    }
}

