# TerminalKit
#### Utility library for console applications in C#.
##### rch_TerminalKit 0.0.1 (in development)
---
## About
`rch_TerminalKit` provides utilities to **facilitate the development of CLI apps**, including:

- **Colorful and interactive** messages (`ConsoleUtils`)
- **Drawing** borders and boxes **on the console** (`Draw`)
- ----
## Installation
**Not yet published on NuGet.** To use it locally:
1. Clone the repository.
2. Compile the DLL.
3. Add it as a reference in your project.
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
