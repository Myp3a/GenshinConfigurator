<img src="pmngear.ico" align="right"
     alt="Paimon gear logo" width="128" height="128">
# Genshin Impact Configurator

A configuration tool for Genshin Impact. It allows user to modify game settings outside of it and adds some nifty features.

[Features](#Features) •
[Installation](#installation) •
[CLI Usage](#CLI-usage) •
[Developing](#Developing)

![Main window](./img/mainscreen.png)
## Features
 - Out-of-the-game graphics settings edit
 - Custom resolution support
 - Save/Load of graphics settings
 - Controls remapping
 - Sensitivity and other control settings
 - Add/Remove controls to base list
 - Mouse remapping
 - Audio settings
 - Language settings
 - Log file viewer
 - Raw config editor

## Installation
Download the [latest release](https://github.com/Myp3a/GenshinConfigurator/releases/latest) and run it!

If you have any questions about app usage, you may consider visiting the [wiki](https://github.com/Myp3a/GenshinConfigurator/wiki).

## CLI Usage
If the executable is called without parameters, the GUI would launch.  
Passing parameters to the executable will launch CLI.  
### Full parameters list:
```
  get        Returns current configuration
    -o, --output    (Default: human) Output format. Vaild values are: human, json, raw

  set        Changes current configuration
    -c, --config        Path to config file to load
    -e, --exec          Executable to run after applying settings
    -a, --execargs      Arguments to the executable
    -r, --resolution    Preferred resoluion. Format: {Width}x{Height}x{Fullscreen (0|1)}
    -s, --set           Changes graphics setting. Format: {SettingID}:{Value}

  help       Display more information on a specific command.

  version    Display version information.
```
### Examples
Load config `high.json` and run Genshin in borderless window
```
GenshinConfigurator.exe set -c high.json -e "C:\Program Files\Genshin Impact\Genshin Impact game\GenshinImpact.exe" -a "-window-mode borderless -popupwindow"
```

Set FPS limit to 30 and render resolution to 0.6x, set resolution to 1234x678 windowed
```
GenshinConfigurator.exe set -s 7:1 -s 2:1 -r 1234x678x0
```

## Developing
> This project is using a custom-built version of [CommandLineParser](https://github.com/commandlineparser/commandline/releases/tag/v2.9.0-preview3). It should be 2.9.0-preview3, NuGet repo still has 2.9.0-preview1.

All contributions are welcome!  

You may contribute in several ways like creating new features, fixing bugs or improving documentation and examples.  

If you want to update the Configurator for a new Genshin version, please, read the [updating guide](./CONTRIBUTING.md).  

Currently, there is no code style in this project. Anything is fine while it's easily readable.  

### What's currently missing
 - Action IDs mappings to their names
 - Graphics settings adaptive UI
 - Optimizations
 - Probably should be rewritten with WPF
---

> *Disclaimer: Genshin Impact Configurator is an unofficial application and not affiliated with miHoYo or Cognosphere Ltd. in any way. "Genshin Impact" is a registered trademark of Cognosphere Ltd.*
