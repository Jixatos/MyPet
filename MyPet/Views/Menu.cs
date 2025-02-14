using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Views
{
    internal class Menu
    {
        public void Options(string nome)
        {
            Console.WriteLine($"Hi, {nome}");
            Console.WriteLine("Select an option by typing the number:\n" +
                "1 - Adopt a Pet\n" +
                "2 - See Adopted Pets\n"+
                "3 - Exit Game\n");
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to:\n");
            Console.WriteLine(" ##   ##  ##   ##  #######  ####### ########\r\n ### ###  ##   ##  ##   ##  ##         ##\r\n #######  #######  #######  #####      ##\r\n ## # ##       ##  ##       ##         ##\r\n ##   ##  #######  ##       #######    ##");
            Console.WriteLine("\nWhat is your name?");
        }

        public void Especies(string[] pokemons)
        {
            Console.WriteLine("Choose your pet:");

            for (int i = 0; i < pokemons.Length; i++)
            {
                Console.WriteLine($"{i+1} - {pokemons[i].ToUpper()}");
            }
        }

        public void Adotar(string name)
        {
            Console.WriteLine("Select an option by typing the number:\n" +
                $"1 - Know more about {name}" +
                $"2 - Adopt {name}\n" +
                "3 - Go back\n");
        }

        public void Adotado(string playerName, string petName)
        {
            Console.WriteLine($"Parabéns {playerName}, você adotou o {petName} com sucesso!");
        }
    }
}
