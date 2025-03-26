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
        private readonly MenuController _menu;
        private readonly Player _player;
        private readonly Messages _messages;

        public Game(MenuController menu, Player player, Messages messages)
        {
            _menu = menu;
            _player = player;
            _messages = messages;
        }

        public void Start()
        {
            _messages.Welcome();
            _player.Name = _menu.ReadUserName();

            while (true)
            {
                _menu.Init(_player.Name);

                int option = _menu.ReadMenuOption(0, 2);

                switch (option)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        string petName = _menu.AdoptOptions();
                        _menu.PetInfoOptions(petName);
                        break;
                    case 2:
                        Pet pet = _menu.SelectPetOption(_player.Pets);
                        _menu.InteractionsOptions(pet);
                        break;
                }
            }
        }
    }
}