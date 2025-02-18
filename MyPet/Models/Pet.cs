using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyPet.Models
{
    internal class Pet
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("height")]
        public double Height { get; set; }

        [JsonPropertyName("weight")]
        public double Weight { get; set; }

        [JsonPropertyName("types")]
        public List<PetType> Types { get; set; } = new List<PetType>();
        //public int hungry { get; set; }
        //public int fatigue { get; set; }
        //public int humor { get; set; }
    }
    internal class PetType
    {
        [JsonPropertyName("type")]
        public TypeInfo Type { get; set; }
    }

    internal class TypeInfo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
