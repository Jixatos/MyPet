using MyPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.View
{
    internal class PetView
    {
        public void PetInfos(Pet pet)
        {
            Console.WriteLine($"\nName: {pet.Name}\nHeight: {pet.Height}\nWeight: {pet.Weight}");

            foreach (var type in pet.Types)
            {
                Console.Write($"{type.Type.Name.ToUpper()} ");
            }
            Console.WriteLine("\n");
        }
        public void HungryLevel(Pet pet)
        {
            Console.WriteLine(pet.Hungry >= 6 ? $"{(pet.Name).ToUpper()} is hungry." : $"{(pet.Name).ToUpper()} isn't hungry.");
        }

        public void FatigueLevel(Pet pet)
        {
            Console.WriteLine(pet.Fatigue >= 6 ? $"{(pet.Name).ToUpper()} is tired." : $"{(pet.Name).ToUpper()} isn't tired.");
        }

        public void HumorLevel(Pet pet)
        {
            Console.WriteLine(pet.Humor >= 6 ? $"{(pet.Name).ToUpper()} is happy." : $"{(pet.Name).ToUpper()} isn't happy.");
        }

        public void FeedMessage(string petName)
        {
            Console.WriteLine($"{petName} ate.");
        }
        public void PlayMessage(string petName)
        {
            Console.WriteLine($"{petName} is happy to play with you.");
        }
        public void SleepMessage(string petName)
        {
            Console.WriteLine($"{petName} slept and fells refreshed.");
        }
    }
}
