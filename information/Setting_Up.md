# Setting up your developing and code diving environment

This document is about setting up the environmnent needed to get started with making modifications and code diving. This is for Windows, Linux experience can be different. The tools used here are a personal preference, alternatives exist.

## VSC, or an alternative IDE

Setting up Visual Studio Code [(Link)](https://code.visualstudio.com/) is one of the first things to do.

The main reason is the Workspaces function and global search, adding Scripts and Settings from the ACS install directory into a Workspace will give you a resource for most of the functionalities.

To quickly find an event or certain property, global search will reduce the need for digging through the folder structures.

For just Code Diving, Scripts and Settings are enough. For modding, Mods\Example should be added as well, as it contains a large amount of example resources.

## Assembly viewing

Not everything is in human (not machine) readable plain text. Some of it is compiled (like the story related functions under settings, also available in the example mod), and there's a large amount of functionality in the assemblies. To view those assemblies, a debugging tool like [dnSpy](https://github.com/dnSpy/dnSpy) is needed.

Extract it in your modding directory (not the Mods folder) and use it to open the assemblies is `Amazing Cultivation Simulator_Data\Managed`, `Assembly-CSharp.dll` contains most of the functions, while `Assembly-CSharp-firstpass.dll` contains certain external functionalities, like FoW and FairyGui.

## Unity Assets

For the resources that are compiled into Unity assets, there's existing documentation. [(Link)](https://github.com/imadr/Unity-game-hacking)

## UI development

The game uses [FairyGUI](https://en.fairygui.com/) for the interface. If you plan on creating custom interfaces, examples and resources are available in the Mods folder, in the `自定义UI相关(UI DIY)` directory.

## 3D Model development

'3D模型导入教学' directory in the Mods folder has resources on 3D model development. Not translated (yet).