using Microsoft.Extensions.DependencyInjection;
using MyPet.Controllers;
using MyPet.Data;

var serviceProvider = DependencyInjectionConfig.Configure();

MenuController menuController = serviceProvider.GetRequiredService<MenuController>();
PlayerController playerController = serviceProvider.GetRequiredService<PlayerController>();
PetController petController = serviceProvider.GetRequiredService<PetController>();
Game game = serviceProvider.GetRequiredService<Game>();


game.Start();



