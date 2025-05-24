# TerminalKit
#### Utility library for console applications in C#.
###### rch_TerminalKit 0.0.1 (in development)
---
## About
`rch_TerminalKit` provides utilities to **facilitate the development of CLI apps**, including:

- **Colorful and interactive** messages (`ConsoleUtils`).
- **User input** prompts with **validation**.
- **Program pauses** in terminal with optional **messages**.
- Control the *program termination* **with delay**.
- **Drawing** borders and boxes **on the console** (`Draw`).
- Global **runtime configuration** for *console behavior*.

Ideal for creating **terminal-based** **games**, tools, and utilities with clear, styled and **configurable console output.**

----
## Installation
**Not yet published on NuGet.** To use it locally:
1. Clone the repository.
2. Compile the DLL.
3. Add it as a reference in your project.

#### Nuget installation in CLI (planned)
`dotnet add package rch_TerminalKit`

---
## Examples of use
```csharp
using rch_TerminalKit;
ConsoleUtils.Message("Hello World!", ConsoleColor.Green);
Draw.Box(20, 5, borderColor: ConsoleColor.Cyan);
```
```csharp
ConsoleUtils.Ask("What's your email adress?", ConsoleColor.Yellow, true);
//the param "true" cleans the terminal before displaying the message
```
---
## Documentation
**Complete documentation** can be generated with **DocFX.**
To visualize it locally:
```bash
cd docs
docfx metadata
docfx build
docfx serve _site
```
---
## (🤝) How to contribute
1. **Fork** the project
2. Create a **branch** for your feature (`git checkout -b my-feature`)
3. Make **commits** (`git commit -m 'My new feature'`)
4. **Push** to the **remote repository** (`git push origin my-feature`)

---
## License
[**MIT LICENSE**](/LICENSE)
