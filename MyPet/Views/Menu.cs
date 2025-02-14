using MyPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Views
{
    internal class Menu
    {

        private Player player;
        public void Options(string nome)
        {
            Console.Clear();
            Console.WriteLine($"{nome}, select an option by typing the number:\n" +
                "1 - Adopt a Pet\n" +
                "2 - See Adopted Pets\n"+
                "0 - Exit Game");
        }

        public void Especies(string[] pokemons)
        {
            Console.Clear();
            Console.WriteLine("Choose your pet:");

            for (int i = 0; i < pokemons.Length; i++)
            {
                Console.WriteLine($"{i+1} - {pokemons[i].ToUpper()}");
            }
        }

        public int ReadUserInputToInt(string? message = null)
        {
            int result;
            while (true)
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Console.WriteLine(message);
                }

                string? input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Entrada inválida. Por favor, tente novamente.");
                    continue;
                }

                if (int.TryParse(input, out result))
                {
                    return result;
                }

                Console.WriteLine("Entrada inválida. Digite um número inteiro.");
            }
        }

        public void ShowPlayerPokemons(List<Pet> pets)
        {
            Console.Clear();
            if (pets.Count == 0)
            {
                Console.WriteLine("The player doesn't have a pet");
                return;
            }
            Console.WriteLine("Pets:");
            foreach (Pet pet in pets)
            {
                Console.WriteLine(pet.Name);
            }
        }

        public void AdoptOptions(string name)
        {
            Console.Clear();
            Console.WriteLine("Select an option by typing the number:\n" +
                $"1 - Know more about {name}" +
                $"2 - Adopt {name}\n" +
                "3 - Go back\n");
        }

        public string ReadUserInput(string? message = null)
        {
            string input;
            do
            {
                if(message != null)
                {
                    Console.Write(message + "\n");
                }
                input = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                }
            } while (string.IsNullOrEmpty(input));

            return input;
        }
    }
}
