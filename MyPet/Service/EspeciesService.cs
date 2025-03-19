using MyPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyPet.Service
{
    class EspeciesService
    {
        public List<string> GetEspeciesNames()
        {
            string json = ReadFile("Data/especies.json");

            Especies especies = JsonSerializer.Deserialize<Especies>(json);

            return especies.Nomes;
        }

        private string GetRelativePath(string relativePath)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", relativePath);
        }

        public string ReadFile(string relativePath)
        {
            string filePath = GetRelativePath(relativePath);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Arquivo não encontrado!", filePath);
            }
            return File.ReadAllText(filePath);
        }
    }
}
