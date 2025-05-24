# rch_TerminalKit 0.1.0 (Not finished yet...)

Utilitary library for Console Applications (CLI) in C#.
---

## About

rch_TerminalKit provides utilities to facilitate the development of CLI apps, including:

- Colorful and interactive messages (ConsoleUtils)
- Drawing borders and boxes in the console (Draw)

---

## Installation

Not yet published in Nuget, to download localy:

1. Clone the repository.
2. Compile the DLL.
3. Add it as a reference in your project.

---

## Exemples of use

```csharp
using rch_TerminalKit;

ConsoleUtils.Message("Hello, world!", ConsoleColor.Green);
Draw.Box(20, 5, borderColor: ConsoleColor.Cyan);