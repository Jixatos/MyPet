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
            Console.Clear();
            Console.WriteLine("Welcome to:\n");
            Console.WriteLine(" ##   ##  ##   ##  #######  ####### ########\r\n ### ###  ##   ##  ##   ##  ##         ##\r\n #######  #######  #######  #####      ##\r\n ## # ##       ##  ##       ##         ##\r\n ##   ##  #######  ##       #######    ##\n");
        }

        public void Goodbye()
        {
            Console.WriteLine("Thanks por playing!");
        }

        public void AdoptCongrats(string petName)
        {
            Console.WriteLine($"\nCongratulations, you adopted {petName} sucessfully!");
        }
    }
}
