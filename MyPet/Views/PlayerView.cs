using MyPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Views
{
    class PlayerView
    {
        public void ShowPlayerPokemons(List<Pet> pets)
        {
            Console.Clear();
            if (pets.Count == 0)
            {
                Console.WriteLine("You doesn't have a pet yet");
                return;
            }
            Console.WriteLine("Pets:");

            for (int i = 0; i < pets.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {pets[i].Name}");
            }
        }
    }
}
