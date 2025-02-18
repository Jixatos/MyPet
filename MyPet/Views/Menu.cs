using MyPet.Models;
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
            Console.Clear();
            Console.WriteLine($"{nome}, select an option by typing the number:\n" +
                "1 - Adopt a Pet\n" +
                "2 - See Adopted Pets\n"+
                "0 - Exit Game");
        }
        public void AdoptOptions(string name)
        {
            Console.Clear();
            Console.WriteLine("Select an option by typing the number:\n" +
                $"1 - Know more about {name}" +
                $"2 - Adopt {name}\n" +
                "0 - Go back\n");
        }
        public void GoBackOptions()
        {
            string input;
            do
            {
                Console.WriteLine("\nGo back to Options?");
                input = ReadUserInput();
                switch (input.ToUpper())
                {
                    case "YES":
                        input = "YES";
                        break;
                    case "NO":
                        input = "NO";
                        break;
                    default:
                        Console.WriteLine("Respond with a Yes or No");
                        break;
                }
            } while (input != "YES");
        }
        public void ConfirmOptions()
        {
            string input;
            do
            {
                Console.WriteLine("Are your sure of your choice?");
                input = ReadUserInput();
                switch (input.ToUpper())
                {
                    case "YES":
                        input = "YES";
                        break;
                    case "NO":
                        input = "NO";
                        break;
                    default:
                        Console.WriteLine("Respond with a Yes or No");
                        break;
                }
            } while (input != "YES");
        }
        public string ReadUserInput(string? message = null)
        {
            string? input;
            do
            {
                if (message != null)
                {
                    Console.Write(message + "\n");
                }

                input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                }
            } while (string.IsNullOrEmpty(input));

            return input;
        }
        public int? UserOptionsConfirm(int min, int max)
        {
            if (!int.TryParse(ReadUserInput(), out int num))
            {
                return null;
            }

            if (num < min || num > max)
            {
                Console.WriteLine("Choose a valid option from the menu");
                return null;
            }

            return num;
        }
    }
}
