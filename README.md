# ToolkitCore

ToolkitCore is a mod for the game RimWorld that provides a standardized way to connect and interact with Twitch.

---

## License

ToolkitCore is licensed under the [MIT License](https://opensource.org/licenses/MIT).
See the `LICENSE` file for the full license text.

---

## Installation

### Steam Workshop

The mod is available on the [Steam Workshop](https://steamcommunity.com/sharedfiles/filedetails/?id=3013877477). You
will also need to subscribe to [Harmony](https://steamcommunity.com/workshop/filedetails/?id=2009463077).

### Manual Installation

1. Download the latest release from the [Releases](https://github.com/harleyknd1/toolkitcore/releases) page.
2. Download the [Harmony](https://github.com/pardeike/HarmonyRimWorld/releases) library.
3. Extract the Harmony archive to your RimWorld Mods folder.
4. Extract the ToolkitCore archive to your RimWorld Mods folder.
5. Enable the mods in the RimWorld Mods menu.
6. Enjoy!

---

## Contributing

Contributions, bug reports, and feature requests are welcome!

---

## Building

To build the mod, you will need the following:

- [Mono](https://www.mono-project.com/download/stable/) if you’re not on Windows.
- [.NET 4.7.2 Developer Pack](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472) if you're on Windows.
- [Git](https://git-scm.com/downloads)
- [RimWorld](https://rimworldgame.com/)
- Your favorite IDE.

We recognize people’s games are different, so we’ve provided properties you may change if the project doesn’t build for
you:

- `SteamRootDir` is a property that points to the directory where your copy of Steam is located.
- `RootDestinationDir` is a property that points to the directory where you’ll house your compiled copy of ToolkitCore. The build process will insert a valid "vX.X\Assemblies" subdirectory at build time.
- `RimWorldModsDir` is a property that points to the directory where your mods folder of RimWorld is located.

You may set either of these properties at build time in your IDE, or through the command line:

- Command line: `msbuild /p:RimWorldModsDir=C:\path\to\mods\dir ...`
- IDE: Refer to your IDE’s documentation on how to set global properties.

---

## Community and Support

- **GitHub**: https://github.com/harleyknd1/toolkitcore
- **Discord**: https://discord.gg/qrtg224
- **Issue Tracker**: https://github.com/harleyknd1/toolkitcore/issues

---

## Acknowledgements

Special thanks to:
- [hodlhodl](https://github.com/hodlhodl1132) for creating ToolkitCore.
- Toolkit Community—Ongoing maintainers and contributors.

---

*Happy Modding!*