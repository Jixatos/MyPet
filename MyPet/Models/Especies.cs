using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyPet.Models
{
    class Especies
    {
        [JsonPropertyName("especies")]
        public List<string> Nomes { get; set; } = new List<string>();
    }
}
