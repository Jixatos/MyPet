using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Views
{
    internal class Messages
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to:\n");
            Console.WriteLine(" ##   ##  ##   ##  #######  ####### ########\r\n ### ###  ##   ##  ##   ##  ##         ##\r\n #######  #######  #######  #####      ##\r\n ## # ##       ##  ##       ##         ##\r\n ##   ##  #######  ##       #######    ##\n");
        }

        public void Goodbye()
        {
            Console.WriteLine("Thanks por playing!");
        }

        public void AdoptCongrats(string playerName, string petName)
        {
            Console.WriteLine($"Congratulations {playerName}, you adopted a {petName} sucessfully!");
        }

        public void MenuOptions(string nome)
        {
            Console.Clear();
            Console.WriteLine($"{nome}, select an option by typing the number:\n" +
                "1 - Adopt a Pet\n" +
                "2 - See Adopted Pets\n" +
                "0 - Exit Game");
        }
    }
}
