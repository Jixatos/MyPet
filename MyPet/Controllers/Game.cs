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
        private readonly MenuView _menuView;
        private readonly PlayerView _playerView;


        private bool playing = true;

        public Game(MenuController menu, Player player, Messages messages, MenuView menuView, PlayerView playerView)
        {
            _menu = menu;
            _player = player;
            _messages = messages;
            _menuView = menuView;
            _playerView = playerView;
        }

        public void Start()
        {
            _messages.Welcome();

            _player.Name = _menu.ReadUserName();

            while (playing)
            {
                _menuView.Options(_player.Name);

                int option = _menu.ReadMenuOption(0, 2);

                switch (option)
                {
                    case 0:
                        playing = false;
                        break;
                    case 1:
                        string petName = _menu.AdoptOptions();
                        _menu.PetInfoOptions(petName);
                        break;
                    case 2:
                        _playerView.ShowPlayerPokemons(_player.Pets);
                        break;
                }
            }
        }
    }
}
