using Microsoft.Extensions.DependencyInjection;
using MyPet.Controllers;
using MyPet.Data;
using MyPet.Service;

var serviceProvider = DependencyInjectionConfig.Configure();

MenuController menuController = serviceProvider.GetRequiredService<MenuController>();
PlayerController playerController = serviceProvider.GetRequiredService<PlayerController>();
Game game = serviceProvider.GetRequiredService<Game>();

playerController.SavePokemonChosen("torchic");
//game.Start();



