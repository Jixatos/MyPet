# MyPet

## About the Project

MyPet is a mini-game inspired by the **Tamagotchi** concept, where the player can adopt, take care of, and interact with a virtual pet based on Pokémon. The goal is to keep the pet happy, feed it, play with it, and ensure it gets enough rest. The game features an interactive flow where the player can view their pets, choose one, and interact to take care of the virtual pet.

## What is a Tamagotchi?

Tamagotchi is an electronic toy created in the 90s, where the player must take care of a virtual pet by ensuring its nutrition, hygiene, happiness, and rest. If the pet is neglected, it may become sad or even "die." MyPet aims to recreate this experience with a special twist by incorporating Pokémon as the virtual pets in the game.

## Project Architecture

The project follows the **MVC (Model-View-Controller)** pattern and uses **Dependency Injection** to manage interactions between system components.

- **MVC (Model-View-Controller):** This structure helps separate business logic (Model), user interface (View), and interaction control (Controller), making the project more organized and easier to maintain.
- **Dependency Injection:** Used to decouple system components, facilitating testing and maintenance.

## Folder Structure

The project is organized as follows:

```
MyPet
├── Controllers      # MVC Controllers
│   ├── EspeciesController.cs
│   ├── Game.cs
│   ├── MenuController.cs
│   ├── PetController.cs
│   ├── PlayerController.cs
│
├── Data            # System data
│   ├── DependencyInjectionConfig.cs
│   ├── especies.json
│   ├── Models      # Data models
│       ├── Especies.cs
│       ├── Pet.cs
│       ├── PetType.cs
│       ├── Player.cs
│       ├── TypeInfo.cs
│
├── Service         # System auxiliary services
│   ├── EspeciesService.cs
│   ├── PokeAPIService.cs
│
├── Views           # User interface (CLI)
│   ├── MenuView.cs
│   ├── Messages.cs
│   ├── PetView.cs
│   ├── PlayerView.cs
├── Program.cs
```

### Folder Explanation

- **Controllers:** Contains the game's control logic and manages interactions between the user and the system.
- **Data:** Stores configuration files and the data model used in the game.
- **Models:** Represents the game's entities, such as **Pet**, **Player**, **Species**, among others.
- **Service:** Contains services that provide auxiliary functionalities, such as consuming the Pokémon API.
- **Views:** Responsible for user interaction via the console.

## Installation

To run **MyPet**, you need to have **.NET SDK** installed on your machine. If you don’t have .NET installed yet, download and install the latest version of **.NET SDK** from the official website:  
🔗 [Download .NET SDK](https://dotnet.microsoft.com/download)

1. Clone this repository:
   ```sh
   git clone https://github.com/your-username/MyPet.git
   ```
2. Navigate to the folder where the repository was cloned.

3. Inside it, enter the project folder:
   ```sh
   cd MyPet/MyPet
   ```
4. Compile and run the game.
   ```sh
   dotnet run
   ```
5. Follow the interactive menu instructions to adopt and interact with your pet!

## Technologies Used

- **C#**
- **.NET Core**
- **Dependency Injection**
- **API Consumption (PokeAPI)**
- **MVC Architecture**

