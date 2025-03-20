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
        private readonly Messages _messages;
        private readonly MenuView _menuView;
        private readonly Player _player;
        

        private bool playing = true;

        public Game(MenuController menu, Messages messages, Player player, MenuView menuView)
        {
            _menu = menu;
            _messages = messages;
            _player = player;
            _menuView = menuView;
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
                        break;
                    case 2:
                        break;
                }
            }
        }
    }
}
