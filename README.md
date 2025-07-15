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

## License

This project is provided for learning purposes and not actively maintained.

```text file="LICENSE"
MIT License

Copyright (c) 2024 Super Adventure

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

---
Happy adventuring!
