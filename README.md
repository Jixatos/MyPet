# MyPet

## Sobre o Projeto

MyPet é um mini game inspirado no conceito de **Tamagotchi**, onde o jogador pode adotar, cuidar e interagir com um pet virtual baseado em Pokémons. O objetivo é manter o pet feliz, alimentá-lo, brincar com ele e garantir que ele descanse adequadamente. O jogo tem um fluxo interativo onde o jogador pode visualizar seus pets, escolher um deles e interagir para cuidar do animal virtual.

## O que é um Tamagotchi?

Tamagotchi é um brinquedo eletrônico criado nos anos 90, onde o jogador deve cuidar de um pet virtual, garantindo sua alimentação, higiene, felicidade e descanso. Se o pet for negligenciado, ele pode ficar triste ou até mesmo "morrer". O MyPet busca recriar essa experiência com um toque especial ao incorporar Pokémons como os bichinhos virtuais do jogo.


## Arquitetura do Projeto

O projeto segue o padrão **MVC (Model-View-Controller)** e utiliza **Injeção de Dependência** para gerenciar as interações entre os componentes do sistema.

- **MVC (Model-View-Controller)**: Essa estrutura ajuda a separar a lógica do negócio (Model), a interface do usuário (View) e o controle das interações (Controller), tornando o projeto mais organizado e fácil de manter.
- **Injeção de Dependência**: É utilizada para desacoplar componentes do sistema, facilitando testes e manutenção.


## Estrutura de Pastas

O projeto está organizado da seguinte maneira:

```
MyPet
├── Controllers      # Controladores do MVC
│   ├── EspeciesController.cs
│   ├── Game.cs
│   ├── MenuController.cs
│   ├── PetController.cs
│   ├── PlayerController.cs
│
├── Data            # Dados do sistema
│   ├── DependencyInjectionConfig.cs
│   ├── especies.json
│   ├── Models      # Modelos de dados
│       ├── Especies.cs
│       ├── Pet.cs
│       ├── PetType.cs
│       ├── Player.cs
│       ├── TypeInfo.cs
│
├── Service         # Serviços auxiliares do sistema
│   ├── EspeciesService.cs
│   ├── PokeAPIService.cs
│
├── Views           # Interface com o usuário (CLI)
│   ├── MenuView.cs
│   ├── Messages.cs
│   ├── PetView.cs
│   ├── PlayerView.cs
├── Program.cs
```

### Explicação das Pastas

- **Controllers:** Contém a lógica de controle do jogo e gerencia as interações entre o usuário e o sistema.
- **Data:** Armazena arquivos de configuração e o modelo de dados utilizado no jogo.
- **Models:** Representa as entidades do jogo, como **Pet**, **Player**, **Espécies**, entre outros.
- **Service:** Contém serviços que fornecem funcionalidades auxiliares, como consumo da API de Pokémons.
- **Views:** Responsável pela interação com o usuário via console.


## Instalação

Para rodar o **MyPet**, é necessário ter o **.NET SDK** instalado na sua máquina. Se ainda não tem o .NET instalado, baixe e instale a versão mais recente do **.NET SDK** no site oficial:  
🔗 [Download .NET SDK](https://dotnet.microsoft.com/download)

1. Clone este repositório:
   ```sh
   git clone https://github.com/seu-usuario/MyPet.git
   ```
2. Navegue até a pasta onde o repositório foi clonado.

3. Dentro dela, entre na pasta do projeto:
   ```sh
   cd MyPet/MyPet
   ```
4. Compile e execute o jogo.
   ```sh
   dotnet run
   ```
5. Siga as instruções do menu interativo para adotar e interagir com seu pet!


## Tecnologias Utilizadas

- **C#**
- **.NET Core**
- **Injeção de Dependência**
- **Consumo de API (PokeAPI)**
- **Arquitetura MVC**


