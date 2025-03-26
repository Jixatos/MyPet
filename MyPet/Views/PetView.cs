using MyPet.Data.Models;
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
            Console.WriteLine("");
        }
        public void HungryLevel(Pet pet)
        {
            Console.WriteLine($"{pet.Name.ToUpper()} is {(pet.Hungry >= 6 ? "hungry." : "not hungry.")}");
        }

        public void FatigueLevel(Pet pet)
        {
            Console.WriteLine($"{pet.Name.ToUpper()} is {(pet.Fatigue >= 6 ? "tired." : "not tired.")}");
        }

        public void HumorLevel(Pet pet)
        {
            Console.WriteLine($"{pet.Name.ToUpper()} is {(pet.Humor >= 6 ? "happy." : "not happy.")}");
        }

        public void FeedMessage(string petName)
        {
            Console.WriteLine($"\n{petName.ToUpper()} ate.");
        }
        public void PlayMessage(string petName)
        {
            Console.WriteLine($"\n{petName.ToUpper()} is happy to play with you.");
        }
        public void SleepMessage(string petName)
        {
            Console.WriteLine($"\n{petName.ToUpper()} slept and fells refreshed.");
        }
    }
}
