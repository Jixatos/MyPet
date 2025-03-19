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
            Console.WriteLine($"Name: {pet.Name}\nHeight: {pet.Height}\nWeight: {pet.Weight}");

            foreach (var type in pet.Types)
            {
                Console.Write($"{type.Type.Name.ToUpper()} ");
            }
            Console.WriteLine("\n");
        }
    }
}
