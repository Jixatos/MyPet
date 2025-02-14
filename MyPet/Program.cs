using MyPet.Models;
using MyPet.View;
using MyPet.Views;
using RestSharp;
using System.Text.Json;

Menu menu = new Menu();
menu.Welcome();

//var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/torchic");
//RestRequest request = new RestRequest("", Method.Get);
//var response = client.Execute(request);

//var json = response.Content.ToString();

//var myPet = JsonSerializer.Deserialize<Pet>(json);

//PetView view = new PetView();

//view.PetInfos(myPet);

menu.Adotado("juan", "torchic");

Console.WriteLine("\nEnd of the game!");