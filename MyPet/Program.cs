using Microsoft.Extensions.DependencyInjection;
using MyPet.Controllers;
using MyPet.Data;
using MyPet.Models;
using MyPet.Service;
using MyPet.View;
using MyPet.Views;
using System.Text.Json;

var serviceProvider = DependencyInjectionConfig.Configure();

MenuController menuController = serviceProvider.GetRequiredService<MenuController>();
Game game = serviceProvider.GetRequiredService<Game>();

game.Start();

