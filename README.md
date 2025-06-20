# BepInEx Template for PEAK

- [BepInEx Template for PEAK](#bepinex-template-for-peak)
  - [Installing](#installing)
    - [From Nuget](#from-nuget)
    - [Manually](#manually)
  - [Creating a Project](#creating-a-project)
    - [Project Structure](#project-structure)
    - [Setting Up The Config File](#setting-up-the-config-file)

## Installing

.NET templates must be installed before they can be used. This means that when you install the template, it doesn't create a new project for you, but now you have the ability to do that.

> [!NOTE]  
> You must use .NET SDK 8 or newer to use this template. Older SDK versions are out of support.

### From Nuget

Run the following command:

```bash
dotnet new install PEAKModding.BepInExTemplate
```

### Manually

If you don't want to install via NuGet or are contributing to this template, you can follow these steps:

- Download this repo's source or clone it to your local computer
- Navigate inside the repository root directory
- Open a Terminal/Powershell/Bash window inside this folder and use the following command to install it: `dotnet new install .`
  - Note: If you are updating the template from an older version use `dotnet new install . --force` instead
  - Note: To uninstall it, run `dotnet new uninstall .` instead

Great! The template is now installed locally as PEAK BepInEx Plugin.

## Creating a Project

> [!TIP]  
> If you've done this before, you can use the `--no-tutorial` option to get rid of tutorial comments.

Open a terminal in your PEAK modding directory, and run:

```sh
 dotnet new peakmod --name ModName --guid com.github.YourAccount.ModName
```

This will create a new directory with the mod name which contains the project.

You now have a (mostly) working setup. For automated build copying you'll need to follow some extra steps!

### Project Structure

This example demonstrates what files should appear and where:

```sh
~/Workspace/PEAK$ dotnet new peakmod --name PeakMod --guid com.github.PEAKModding.PeakMod
The template "PEAK BepInEx Plugin" was created successfully.

~/Workspace/PEAK$ cd PeakMod/
~/Workspace/PEAK/PeakMod$ tree
.
├── Config.Build.user.props.template
├── Directory.Build.props
├── Directory.Build.targets
├── LICENSE
├── PeakMod.sln
├── NuGet.Config
├── README.md
└── src
    └── PeakMod
        ├── PeakMod.csproj
        └── Plugin.cs

3 directories, 9 files
```

The C# source files for your mod are located in `./src/<project-name>/`. All files above that are more generic project configuration files.

The `Directory.Build.*` files contain shared configuration for all projects in subdirectories. The project is configured so that it's easy to add new projects into your project solution. Even if you don't need that, it's good to follow this standard project structure.

### Setting Up The Config File

At the root of your new project you should see `Config.Build.user.props.template` this is a special file that is the template for the project's user-specific config. Make a copy of this file and rename it `Config.Build.user.props` without the template part.

This file will copy your assembly files to a plugins directory and it can be used to configure your paths to the game files and BepInEx plugins directory if the defaults don't work for you.
