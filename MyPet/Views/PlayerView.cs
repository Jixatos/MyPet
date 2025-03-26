using MyPet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Views
{
    class PlayerView
    {
        private readonly Player _player;

        public PlayerView(Player player)
        {
            _player = player;
        }

        public void ShowPlayerPets(List<Pet> pets)
        {
            Console.WriteLine("\nPets:");

            for (int i = 0; i < pets.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {pets[i].Name}");
            }
        }

        public void NoPets()
        {
            Console.WriteLine($"{_player.Name}, you doesn't have an adopted pet yet.");
        }
    }
}
