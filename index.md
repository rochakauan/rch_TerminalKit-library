# TerminalKit Documentation

**Welcome to the official documentation** for **rch_TerminalKit** — a lightweight, customizable console utility toolkit for .NET CLI applications.
###### Last documentation update: 2025-05-24 Saturday

## ► Overview

**TerminalKit** provides utility methods for:

- **Styled console** message output.
- **User input** prompts with **validation**.
- **Program pauses** with optional **messages**.
- Controlled program **termination with delay**.
- Global runtime configuration for console behavior.

Ideal for creating **terminal-based** **games**, tools, and utilities with clear, styled and **configurable console output.**

---

## ► Quick Example

```csharp
using rch_TerminalKit;

ConsoleUtils.Message("Hello, World!", ConsoleColor.Cyan);
string name = ConsoleUtils.Ask("What's your name?");
ConsoleUtils.Pause();
ConsoleUtils.KillTerminal();
```

## ► Available Namespaces
`rch_TerminalKit.ConsoleUtils`
`rch_TerminalKit.TerminalConfig`
`rch_TerminalKit.TerminalDefaults`

## ► Configuration Example
```csharp
TerminalConfig.DefaultMessageColor = ConsoleColor.Green;
TerminalDefaults.DefaultPauseMessage = "Tap any key to proceed!";
```

You can **reset values** to their **original defaults** at any time:
```csharp
TerminalConfig.ResetDefaults();
TerminalDefaults.ResetDefaults();
```

## ► API Documentation
**Check the API Reference** section for detailed information **about each class, property, and method.**
rch_TerminalKit.ConsoleUtils
TerminalConfig
TerminalDefaults

## ► Installation (Planned)
**rch_TerminalKit** will be available as a *NuGet package soon:*

`dotnet add package rch_TerminalKit`

## ► License
**MIT License.**
See [LICENSE](https://github.com/rochakauan/rch_TerminalKit-library/blob/main/LICENSE "LICENSE") file for details.

## 🤝 Contributing
**Contributions are welcome!** Check out the[ **GitHub repository **](https://github.com/rochakauan/rch_TerminalKit-library/tree/main " **GitHub repository **")and open an issue or *pull request.*

------------


### Thanks for using TerminalKit!
►  [@rchkauan](https://www.instagram.com/rch_kauan?igsh=MTY3OGxma2IycnU0aA== "@rchkauan")
► [rchkauan on gihub](https://github.com/rochakauan "rchkauan on gihub")