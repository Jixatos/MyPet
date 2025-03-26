using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyPet.Data.Models
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

        private int _hungry;
        private int _fatigue;
        private int _humor;

        public int Hungry
        {
            get => _hungry;
            set => _hungry = Math.Clamp(value, 0, 10);
        }

        public int Fatigue
        {
            get => _fatigue;
            set => _fatigue = Math.Clamp(value, 0, 10);
        }

        public int Humor
        {
            get => _humor;
            set => _humor = Math.Clamp(value, 0, 10);
        }
        public Pet()
        {
            Hungry = 5;
            Fatigue = 5;
            Humor = 5;
        }

        public Pet(int hungry, int fatigue, int humor)
        {
            Hungry = hungry;
            Fatigue = fatigue;
            Humor = humor;
        }

        public void Eat()
        {
            Hungry -= 2;
            Humor += 1;
        }

        public void Play()
        {
            Humor += 3;
            Hungry += 2;
            Fatigue += 2;
        }

        public void Sleep()
        {
            Fatigue -= 5;
            Hungry += 3;
        }
    }
}
