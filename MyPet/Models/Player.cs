using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Models
{
    internal class Player
    {
        public string Name {  get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();

        public void AdoptPet(Pet pet)
        {
            Pets.Add(pet);
        }
    }
}
