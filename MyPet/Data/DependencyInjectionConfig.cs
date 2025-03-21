using Microsoft.Extensions.DependencyInjection;
using MyPet.Controllers;
using MyPet.Models;
using MyPet.Service;
using MyPet.View;
using MyPet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Data
{
    public static class DependencyInjectionConfig
    {
        public static ServiceProvider Configure()
        {
            return new ServiceCollection()
                .AddSingleton<EspeciesService>()
                .AddSingleton<MenuView>()
                .AddSingleton<PetView>()
                .AddSingleton<MenuController>()
                .AddSingleton<Player>()
                .AddSingleton<Messages>()
                .AddSingleton<Game>()
                .AddSingleton<PlayerController>()
                .AddSingleton<PokeAPIService>()
                .AddSingleton<PetController>()
                .AddSingleton<PlayerView>()

                .BuildServiceProvider();
        }
    }
}
