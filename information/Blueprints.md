# Blueprints

This document is for Blueprints, as far as the technical details are concerned. Where the files are located and what they consist of, not how to create one ingame.

## Structure and location of a blueprint

Blueprints can be categorized under user created content, and locally created blueprints are found under the Saves directory within the installation path.

All locally created blueprints can be found within the CreateBlueprint mod. CreateBlueprint is a decent example of a typical blueprint mod, based on its strcture, a minimal blueprint mod would look something like the following:

* `CreateBlueprint` *(or [Mod folder])* Directory
    * `Info.json` *(similar to any other mod)*
    * `Blueprint` Directory containing the blueprints
        * `BP_ID` Directory a single blueprint with that ID
            * `BP_ID.png` Preview image for the blueprint with that ID
            * `Content.json` The actual blueprint

The blueprint itself is made up of two files within a single directory, named after the ID of the blueprint.

* `Content.json` - Containing the blueprint data structure
* `BP_ID.png` - The preview image for the blueprint, preferably in a 1:1 X:Y ratio

### Content.json content

A blueprint data structure is defined by `XiaWorld.BlueprintData`, and consists of the following elements:

* `id` - `BlueprintData.id`, an integer, automatically generated, the actual ID of the blueprint.
* `displayname` - `BlueprintData.displayname`, a string, the name of the blueprint displayed ingame.
* `minx` - `BlueprintData.minx`, an integer, X value of the lower left corner
* `miny` - `BlueprintData.miny`, an integer, Y value of the lower left corner 
* `maxxx` - `BlueprintData.maxx`, an integer, X value of the upper right corner
* `maxy` - `BlueprintData.maxy`, an integer, Y value of the upper right corner
* `blueprintBuildDatas` - `BlueprintData.blueprintBuildDatas`, a list of entities within the Blueprint, in the format of `XiaWorld.BlueprintBuildData`
* `des` - `BlueprintData.des`, a string, the description of the blueprint displayed ingame, containing the required building materials (automatically generated)
* `creat` - `BlueprintData.creat`, an integer, set to 2 when the blueprint is created by `BlueprintEditor.DoCreat`, set to 1 when the blueprint is created by `XiaWorld.BlueprintMgr.CreatBlueprint`

While the structure above is mostly skeletal in nature, the actual entities are defined within `XiaWorld.BlueprintBuildData`, which is used in `blueprintBuildDatas` and consists of the following elements:

* `x` - `BlueprintBuildData.x`, an integer, X value of the entity
* `y` - `BlueprintBuildData.y`, an integer, Y value of the entity
* `name` - `BlueprintBuildData.name`, a string, `ThingDef`/name of the entity
* `stuffname` - `BlueprintBuildData.stuffname`, a string, `ThingDef`/name of the material for the entity
* `dir` - `BlueprintBuildData.dir`, a `g_emThingDir` value, the rotation of the entity. possible values are:
    * `None` - 0
    * `Up` - 1
    * `Right` - 2
    * `Down` - 3
    * `Left` - 4
* `itemdefname` - `BlueprintBuildData.itemdefname`, a string, `ThingDef`/name of a secondary entity, used for displays and other relevant containers
* `m_sMod` - `BlueprintBuildData.m_sMod`, a string, the source of the entity when it's a modded entity. `null` for vanilla entities

## Blueprint Labels

Blueprint Labels can be used to categorize existing blueprints, which is useful when dealing with a large amount of blueprints.

A Blueprint can only have a single Label assigned to it, but the Label can be changed at will.

The Label itself is limited to 5 characters, and internally, Blueprint<>Label assignment is done with the `XiaWorld.GlobleDataMgr.BlueprintLabel` dictionary, as a part of global saving and loading.

Theoretically, Label assignment can be exported and imported. However, no such tool exists at this moment.

## Blueprint limits

When dealing with blueprints, there are two noticeable ingame limits, both related to 20.

### Size limits

A blueprint is limited in size to 20x20, which is defined in multiple places. One of which is `XiaWorld.BlueprintData.CheckBlueSize`, a `bool` for verifying blueprint size. Another is the integer `XiaWorld.UILogicMode_Command.bluemax`, which is used to limit the dragging area to 20 in any direction.

A possible workaround can be had with console commands. Running the following script while in a regular game mode will increase the dragging area limit to 100, which should be large enough for any larger plans. If it's still too small, change the relevant value.
``` lua
xlua.private_accessible(CS.XiaWorld.UILogicMgr);
xlua.private_accessible(CS.XiaWorld.UILogicMode_Command);
CS.XiaWorld.UILogicMgr.Instance.m_mapModes[2].bluemax=100;
```

However, when a blueprint is created that is larger than the vanilla area, preview image generation can have issues. Broken images can be resolved by manually creating the preview image and overwriting the previously generated white image.

### Count limits

A blueprint mod on the workshop is limited to 20 blueprints. The limitation is assigned by `BlueprintEditor.UploadData`, but the restriction is only relevant for mods being uploaded on the workshop.

For external blueprint mods, published outside of the Steam Workshop/Realms Palace, the blueprint count limit is not relevant.