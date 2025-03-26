﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Data.Models
{
    internal class Player
    {
        public string Name {  get; set; }
        public List<Pet> Pets { get; } = [];

        public void AdoptPet(Pet pet)
        {
            Pets.Add(pet);
        }
    }
}
