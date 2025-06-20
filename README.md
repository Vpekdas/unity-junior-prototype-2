# unity-junior-basic-gameplay-prototype-2

## Screenshots

https://github.com/user-attachments/assets/9ca339ff-f45a-4c4f-9527-3bd61ed43b1e

https://github.com/user-attachments/assets/fccb4b1c-5a48-4b6a-afde-f4744f5ff58f

## Table of Contents
1. [Description](#description)
2. [Installation](#installation)
3. [Run](#run)
4. [Credits](#credits)
5. [Contributing](#contributing)
6. [License](#license)

## Description

This prototype is part of the Junior Programmer Pathway from Unity Learn. Its purpose is to teach the fundamentals of basic gameplay through scripting in C#.
Each prototype includes:
- A Learning section that guides you through building core features step by step. Later, you can complete bonus challenges categorized from easy to expert
- A Challenge section where you're given a broken or incomplete project to fix and extend, testing your understanding and problem-solving skills.

### Purpose

The objective of this prototype is to create two simple games:

- **Feed the Animal** : A top-down game where animals run across the screen, and your goal is to feed them with pizzas.
- **Catch the Ball** : Balls fall from the top, and you can summon a dog to run from right to left and catch them.

#### Bonus Features (for Feed the Animal) :
- Player can move forward/backward within a limited range.
- Animals also spawn from the left and right; collisions cause a Game Over.
- Console displays:
  - Lives = 3, Score = 0 at start.
  - Score increases when feeding animals.
- Each animal has a hunger bar that fills with each feeding.
  - Different animals require different amounts of food to be satisfied.

#### Fixing problems (For Catch the Ball) : 
- Dogs are spawning at the top of the screen -> Make the balls spawn from the top of the screen.
- The player is spawning green balls instead of dogs -> Make the player spawn dogs .
- The balls are destroyed if anywhere near the dog -> The balls should only be destroyed when coming into direct contact with a dog.
- Nothing is being destroyed off screen -> Balls should be destroyed when they leave the bottom of the screen and dogs should be destroyed when they leave the left side of the screen.
- Only one type of ball is being spawned -> Ball 1, 2, and 3 should be spawned randomly.
- The spawn interval is always the same -> Make the spawn interval a random value between 3 seconds and 5 seconds.
- The player can “spam” the spacebar key -> Only allow the player to spawn a new dog after a certain amount of time has passed.
## Controls

**Feed the Animal** (Player 1)
| **Key** | **Action**           |
|:-------:|----------------------|
| `W` or `↑`| Move forward       |
| `S` or `↓`| Move backward      |
| `A` or `←`| Turn left          |
| `D` or `→`| Turn right         |
| `ESCAPE`  | Return to menu     |

**Catch the Ball**
| **Key** | **Action**           |
|:-------:|----------------------|
| `SPACE`  | Let the dog run     |
| `ESCAPE`  | Return to menu     |

### Technologies used

- **Unity** – Version 6000.0.47f1
- **C#** – Used for gameplay scripting
  
### Challenges and Future Features

One of the main challenges in this project was creating and interacting with a health bar. Through this process, I started to understand how the canvas works and, as a result, improved my skills for future prototypes.

## Installation

You can download pre-built releases for your supported operating system from the GitHub Releases page. Available builds include:
- macOS
- Windows
- Linux

## Run

To run the program, simply double-click the executable file for your operating system.

### MacOS

Unzip and open the .app file.

### Windows

Unzip and double-click the .exe file.

### Linux

```bash
chmod +x Prototype_2_Linux.x86_64
./Prototype_2_Linux.x86_64
```

### Web

Play on [browser](https://vpekdas.github.io/unity-junior-basic-gameplay-prototype-2/)

## Credits

This project is based on the Unity **Junior Programmer Pathway** by Unity Learn.
Many thanks to the instructors for their excellent step-by-step video tutorials and guidance.

## Contributing

To report issues, please create an issue here:  [issue tracker](https://github.com/Vpekdas/unity-junior-player-control-prototype-1/issues).

If you'd like to contribute, please follow the steps outlined in [CONTRIBUTING.md](CONTRIBUTING.md).

## License

This project is licensed under the [MIT License](LICENSE).
