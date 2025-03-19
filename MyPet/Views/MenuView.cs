using MyPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Views
{
    internal class MenuView
    {
        public void Options(string nome)
        {
            Console.Clear();
            Console.WriteLine($"{nome}, select an option by typing the number:\n" +
                "1 - Adopt a Pet\n" +
                "2 - See Adopted Pets\n"+
                "0 - Exit Game");
        }
        public void AdoptOptions(string name)
        {
            Console.Clear();
            Console.WriteLine("Select an option by typing the number:\n" +
                $"1 - Know more about {name}" +
                $"2 - Adopt {name}\n" +
                "0 - Go back\n");
        }
        public void ShowEspecies(List<string> pokemons)
        {
            Console.Clear();
            Console.WriteLine("Choose your pet:");

            for (int i = 0; i < pokemons.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {pokemons[i].ToUpper()}");
            }
        }
    }
}
