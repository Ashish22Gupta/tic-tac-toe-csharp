# ⭕ Tic-Tac-Toe
### Console-Based X vs O Game in C#

> ⚠️ **DISCLAIMER:** This is a **personal learning and portfolio project**. It is a beginner-friendly C# console application demonstrating object-oriented design, 2D arrays, and game-loop logic. No external libraries or frameworks are used — it runs on the standard .NET runtime only.

A classic two-player Tic-Tac-Toe game where you play as **X** against a computer opponent (**O**) inside the terminal. Built with a clean, class-based architecture in C#, it validates every move, tracks remaining spaces, and detects wins, losses, and draws — all through an interactive text interface.

![Version](https://img.shields.io/badge/Version-1.0.0-512BD4)
![Status](https://img.shields.io/badge/Status-Portfolio%20Project-F4B400)
![Platform](https://img.shields.io/badge/Platform-Console%20%28.NET%29-2D6A4F)

---

## 🔗 Links

- **Source Code:** [github.com/Ashish22Gupta/tic-tac-toe-csharp](https://github.com/Ashish22Gupta/tic-tac-toe-csharp)

> 💡 *No live demo — this is a console application. Clone the repo and run it locally.*

---

## ✨ Implemented Features

### 🎮 Core Gameplay
- **Human vs Computer** - You play `X`; the computer plays `O`.
- **Position-Based Input** - Enter a number from `1–9` to place your mark on the 3×3 grid.
- **Turn Alternation** - Control switches between player and computer after every valid move.
- **Win / Lose / Draw Detection** - Full scan of all 8 winning lines (3 rows, 3 columns, 2 diagonals) after every move.

### 🛡️ Robust Input Handling
- **Range Validation** - Rejects inputs outside `1–9` and non-numeric entries via `int.TryParse`.
- **Occupied-Cell Check** - Prevents overwriting an already-filled cell.
- **Re-Prompt Loop** - Invalid or duplicate choices loop the player back to selection instead of crashing.

### 🧩 Object-Oriented Design
Each responsibility is isolated in its own class:
| Class | Responsibility |
|-------|----------------|
| `InsertDefaultValue` | Initializes the board with `-` placeholders |
| `ShowMatrix` | Renders the board to the console |
| `UserInput` | Places the player's `X` at a chosen position |
| `ComputerInput` | Places the computer's `O` at a random available position |
| `RemainingSpaces` | Lists empty cells and returns the count |
| `Winner` | Checks all winning combinations for `X` and `O` |
| `HelloWorld` | Main game loop and flow control |

### 🤖 Simple AI Opponent
- **Random Move Selection** - The computer picks uniformly from the list of remaining empty positions.
- **No Overwrite Risk** - Uses the `RemainingSpaces` list so it never targets a filled cell.

### 🧠 Game Loop Logic
- **Move Counter** - Ends the game after 9 moves with a draw message if no winner is found.
- **Early Termination** - A `gameOver` flag breaks the loop immediately once a win is detected.

---

## 🛠️ Tech Stack

| Technology | Purpose |
|------------|---------|
| **C#** | Core language — classes, methods, arrays |
| **.NET Runtime** | Execution environment (console app) |
| **2D Char Array** | Board representation (`char[3,3]`) |
| **System.Random** | Computer move selection |
| **Console I/O** | `Console.ReadLine` / `Console.Write` for interaction |

---

## 📁 Project Structure

```text
tic-tac-toe-csharp/
└── Tik-Tak-Toe.cs          # Single-file console app (all classes + Main)
