# Just a C-Sharp adventure game

Super Adventure is a simple C# adventure game designed to demonstrate basic concepts of object-oriented programming and Windows Forms development. The game allows players to explore locations, battle monsters, complete quests, collect loot, and level up their character.

## Features

- **Explore Locations:** Move between different locations, each with its own description and possible requirements to enter.
- **Battle Monsters:** Encounter and fight various monsters for experience points and gold.
- **Complete Quests:** Accept and complete quests for rewards.
- **Collect Items and Loot:** Pick up items, weapons, and loot dropped by monsters.
- **Level Up:** Gain experience points and level up your character.
- **Inventory Management:** Track items and weapons in your inventory.
- **Windows Forms Interface:** Play the game in a graphical user interface.

## Getting Started

### Prerequisites

- Windows OS
- .NET Framework 4.5
- Visual Studio (recommended for building and running the project)

### Running the Game

1. Clone the repository:
   ```sh
   git clone https://github.com/ash-norsidi/super-adventure.git
   ```
2. Open the solution (`SuperAdventure.sln`) in Visual Studio.
3. Build the solution.
4. Run the project. The main form (`SuperAdventure`) will launch the game.

## Project Structure

- `SuperAdventure/Engine/`  
  Contains core game logic classes such as `Player`, `Monster`, `Location`, `Quest`, `Item`, and more.

- `SuperAdventure/SuperAdventure/`  
  Contains the Windows Forms application and UI logic.

## Main Classes

- **Player:** Represents the player character, including stats like hit points, gold, experience, and level.
- **Monster:** Represents monsters that the player can battle.
- **Location:** Defines places the player can visit.
- **Quest:** Contains quest details and rewards.
- **Item / Weapon / LootItem:** Represent items the player can collect and use.

## Example

When you start the game, you will begin at "Home". You can view your stats and begin your adventure by exploring locations and interacting with monsters and quests.

## Future Enhancement

This project was created for learning purposes and not actively maintained.

---
Happy adventuring!
