﻿using MyPet.Data.Models;
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
                _menu.Start(_player);
            }
        }
    }
}