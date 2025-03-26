using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyPet.Data.Models
{
    class PetType
    {
        [JsonPropertyName("type")]
        public TypeInfo Type { get; set; }
    }
}
