# ACS Harmony Patching

This is a resource to get you started with code injection for Amazing Cultivation Simulator, using Harmony [Link](https://harmony.pardeike.net/articles/intro.html).
The focus is on how to implement patching for ACS, not Harmony itself. For Harmony documentation, check out their site.

I use Visual Studio 2019 as my IDE, but the basic concepts are still valid for other environments. Written by iguana, credit to inari (for bringing this up and the example), neverjoke (for bringing up Harmony), Keshire (for the Lua loading method), and heihei (for ModLoaderLite).

## Prerequisites:

You’ll need the following to create your own patches:

- Development Environment – for coding and compiling
- Harmony assembly – best to use 0Harmony.dll from ModLoaderLite (MLL from this point)
## Setting up your solution

The first step is to set up your solution. Target a .NET framework Class Library. For Names, keep it simple. For both Solution and Project, use the mod name (from Info.json). Keep the solution away from the AmazingCultivationSimulator install folder.

After the solution is created, set up your project properties.

### Application
Assembly name and Default namespace should be kept simple (mod name from Info.json).

Target framework must be .NET Framework 3.5, Unity 3.5 .net works as well.

Assembly Information should be set accordingly, purely for polish.

### Build
Output path can be set directly to your created Mod folder for ease of use, but unnecessary as directly copying the assemblies works as well.

Under Advanced output options, Debugging information should be set to None, based on Harmony usage for Rimworld. It’s not necessary, but it reduces the amount of information you get. Which is nice.

After the project properties have been set up, it’s time to move on to references.

### References

Add the following assemblies to your references:
- Assembly-CSharp.dll from AmazingCultivationSimulatorData\Managed
- Assembly-CSharp-firstpass.dll from AmazingCultivationSimulatorData\Managed
- UnityEngine.dll from AmazingCultivationSimulatorData\Managed
- 0Harmony.dll from MLL
- Other assemblies when they are needed.

Existing assemblies (Assembly-CSharp.dll, Assembly-CSharp-firstpass.dll, UnityEngine.dll) must have their Copy Local value set to false, as they already exist for the game.

0Harmony.dll should have the Copy Local value set to false only if you’re using MLL as a prerequisite mod. If you’re loading Harmony by Lua, set Copy Local to true.

After you’re done with references, set up the Harmony patching method.

## Harmony patching

To apply Harmony patches to ACS, there are 2 methods that I’ll go over. Using MLL as a prerequisite mod, or using lua to initialize the Harmony patch.

Which one to use?

If you can deal with MLL, it’s best to use it, for better compatibility with other patches.

If you don’t intend for it to be used with other patches, go for Lua loading.

### MLL

Using MLL as a prerequisite mod is one way to implement your patches. As Harmony is already implemented by MLL, you won’t have to implement it yourself. With a single Harmony patching done by MLL, there’s a lower chance of the patch load order being messed up. However, you’re forced to use MLL and the changes it implements.

### Lua loading

Using a custom Lua script to directly load your mod is another way to implement your patches.

You’ll have to create your own loading method, and include Harmony assemblies with your mod.

You’ll have more control over your patch content, but there can be issues when using multiple patches simultaneously.

When using multiple patches, their loading order can cause unintended effects.

## Using MLL

For MLL, add it as a ParentMod under your Info.json. The current version at the time of writing is 4.1.

    "ParentModInfo":["ModLoaderLite,4.1,heihei,ModLoaderLite,1997170546"]

In your project namespace, add a [HarmonyPatch]. Create a class (doesn’t need to be public) for the Harmony patching method and write your code there.

It’s also possible to create external functions that you use in Lua, if you’re more comfortable in C# than Lua.

## Using Lua loading

For Lua loading, create a Lua script to load your assemblies. Here’s what one would look like:
```lua
local Modname = GameMain:GetMod("Modname");
function Modname:OnBeforeInit()
  xlua.private_accessible(CS.XLua.LuaEnv)
  xlua.private_accessible(CS.XLua.ObjectTranslator)
  local thisData = CS.ModsMgr.Instance:FindMod("Modname", nil, true)
  local thisPath = thisData.Path
  local mllFile = CS.System.IO.Path.Combine(thisPath, "Modname.dll")
  local asm = CS.System.Reflection.Assembly.LoadFrom(mllFile)
  CS.XiaWorld.LuaMgr.Instance.Env.translator.assemblies:Add(asm)
  CS.ModnameNamespace.ModnameClass.Patch()
end
```
- Where Modname is the name of your mod in Info.json,
- ModnameNamespace is the namespace of your assembly,
- ModnameClass is the main class for that assembly.

In your assembly, create the Patch class (public). It doesn’t need to be called Patch, but I’m using that name to keep it simple. Here’s what one would look like:
```C#
        public static void Patch()
        {
            try
            {
                Assembly.LoadFrom(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "0Harmony.dll"));
                Harmony harmony = new Harmony("Modname.Mod");
                harmony.PatchAll();
                KLog.Dbg("[Modname] Loaded!");
            }
            catch (Exception e)
            {
                KLog.Dbg("[Modname] error" + e.ToString());
            }
        }
```
Now create a class, doesn’t need to be public, for the Harmony patching method and write your code there. While it doesn’t need to be public, it needs to be within the class of the Mod, alongside the Patch() method.

It’s also possible to create external functions that you use in Lua, if you’re more comfortable in C# than Lua.

Calling them from Lua requires nothing more than CS.Namespace.Class.Function().

Or for our example, CS.ModnameModNamespace.ModnameClass.Function().

## Actual coding

After the patching method is implemented, go and code. When you’re done, build it and test it out ingame. 

For patches, after activating the mod, restart the game to ensure the assemblies get loaded.

Remember, mods get loaded in sequence, if you’re using the MLL method, your mod needs to come after MLL.
