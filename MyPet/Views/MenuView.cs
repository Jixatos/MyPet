using MyPet.Data.Models;
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
        public void Options(string playerName)
        {
            Console.Clear();
            Console.WriteLine($"{playerName}, select an option by typing the number:\n" +
                "1 - Adopt a Pet\n" +
                "2 - See Adopted Pets\n"+
                "0 - Exit Game");
        }

        public void PetInfoOptions(string petName)
        {
            Console.Clear();
            Console.WriteLine("Select an option by typing the number:\n" +
                $"1 - Know more about {petName}\n" +
                $"2 - Adopt {petName}\n" +
                "0 - Go back");
        }

        public void ShowEspecies(List<string> pets)
        {
            Console.Clear();
            Console.WriteLine("Choose your pet:");

            for (int i = 0; i < pets.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {pets[i].ToUpper()}");
            }
        }

        public void Interactions(string petName)
        {
            Console.Clear();
            Console.WriteLine("Select an option by typing the number:\n" +
                $"1 - Know how {petName} is\n" +
                $"2 - Feed {petName}\n" +
                $"3 - Play with {petName}\n" +
                $"4 - Put {petName} to sleep\n" +
                "0 - Go back");
        }
    }
}
