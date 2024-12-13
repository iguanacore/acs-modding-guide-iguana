# ACS modding guide by iguana
A comprehensive resource on modifying Amazing Cultivation Simulator. An attempt was made earlier, but was abandoned due to reasons. This is another attempt at it. Written by iguana#3987, the experienced one. But first, some words of wisdom:

**I am not responsible if you manage to ruin your game.**

**Never directly edit the game files, use Mods.**

**Avoid testing Mods with your main save game.**

**Backup your data before doing anything.**

**Don't upload anything if you lack permission from the original author.**

# Introduction to modding

ACS can be extensively modded. For simpler functions, the Realms Palace with its Content Editor is a good introduction to modding. Custom items, reincarnators, as well as blueprints are very doable without touching a single file. But if you want to do anything more complex than that, the RP/CE isn’t capable of it. If you want to start with the Realms Palace, there are existing resources.

For reincarnators, a short guide for making reincarnators on Steam: [LINK](https://steamcommunity.com/sharedfiles/filedetails/?id=2306519877)

For custom items, a few posts about their capabilities, any questions about them can be directed to the author: [LINK](https://arch.b4k.co/vg/thread/345895292/#345919017)

For blueprints, it’s not that different from the Land of Illusions or even basic gameplay. [Additional blueprint related information can be found here.](information/Blueprints.md)

# General Conceptions
The Readme_EN.txt in the Mods folder is a good resource to get started. Go over it. Done?
Things to remember out of that:

Modifications are loaded at start. The most basic examples are items created with the Realms Palace content editor. Even if you made them to test things out and didn’t finish with them, they are still loaded. Be careful with them. Clearing up your saves\CreateItems folder is useful to avoid having some “test” items spawning during a run.

XML files can be added freely. The program will go through all the directories, including sub directories. You should follow the logic of the original directories, you can face issues with loading if you don’t follow it. Keep `<ThingDefs>` in ThingDef, keep formations in Zhen, and so on.
  
Def with same names will be overwritten according to loading order. If you plan on changing any of the existing Defs (things contained in a `<Def>`), always use mods. If it’s a base definition that is used as a parent, be prepared for the changes to be used by all the children as well. If you don’t know what you’re doing, this is an easy way to screw things up. Using prefixes for your custom content can reduce the conflicts for Defs.
  
Please solve same ID problems of txt file which use number as ID on your own. One line will be overwritten by later lines with the same ID. If you plan on adding something, use unique IDs. If you plan on changing something, use the same ID as the thing you’re changing. Using multiple mods can bring ID conflicts, no reasonable way around that (yet).
  
Now it is supported to use luac to encrypt Lua scripts. Please use luac.exe in the MOD directory to compile, the system will load files end with luac. You can also use compiled Lua scripts, the game will load them. No need to obfuscate your code with external tools for security|privacy reasons, the developers have provided one for you.

# Game Files
To understand how the game works, a good starting point is to go digging into the files. You shouldn’t modify something without knowing the mechanics. The existing resources are helpful in learning them. In the installation directory, there are five important folders for modding.
  
[InstallDirectory]\Amazing Cultivation Simulator_Data
  
Contains assets and assemblies. Assets files for the sprites and models, Managed folder contains the assemblies. Assembly-CSharp.dll and Assembly-CSharp-firstpass.dll contains most of the game logic.
  
[InstallDirectory]\Mods
  
Contains the Example mod along with other utilities. All local mods (and everything not from the Workshop) goes here. Readme_EN.txt will give you the brief overview modding and contains useful links to the API.
  
[InstallDirectory]\Scripts
  
Contains Lua scripts and only Lua scripts.
  
[InstallDirectory]\Settings
  
Contains the definitions. Includes .txt files (like secrets.txt) and .XML files (most definitions). Readme_EN.txt has an overview of what things are.
  
[InstallDirectory]\Logs
  
Contains the log folder, can be crucial for debugging your mods.

# Your first proper modification
With the basics out of the way, here’s how to make a modification.
  
•	Create a new folder in the Mods folder. Keep the name simple, as it will be used as the Name of the mod.
•	Create and populate the Info.json inside that folder. A minimal example is below.
  
The folder is named ExampleMod, and this is the minimal Info.json inside:

```json
{"Name":"ExampleMod",
"DisplayName":"Example Display name",
"GameVersion":1.177,
"Version":1.0,
"Desc":"Example Description",
"Author":"iguana"}
```

You have now made a proper mod. It can be activated in the Mod Manager, but it does nothing. To fix that, add the content to it. Either start by exploring the Example mod, or look at other mods for inspiration.
  
For example mods, check out the Examples folder.

For finding out how it works, check out the Information folder, contains resources for code diving.
  
This repository will remain a work in progress, content will be added over time.
