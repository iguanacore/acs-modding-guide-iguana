# External Blueprints

This example contains a Blueprint mod without using the Workshop/Realms Palace.

[For blueprints in general, check the docs.](../../information/Blueprints.md)

## The basics

Populate the `info.json`, and create the `Blueprint` directory.

```json
{"Name":"ACS_M_EX_09",
"DisplayName":"Example Blueprints",
"GameVersion":1.266,
"Version":1.0,
"Desc":"Check the docs",
"Author":"iguana"}
```

### Migrating existing blueprints

Navigate to your created blueprints, found under:
>`[Install Directory]\saves\CreateBlueprint\Blueprint`

Migrate the desired blueprints to the previously created `Blueprint` directory, make sure to include all relevant files within the directory.

The example contains a single blueprint, with the ID `-1476558188`. Which means that the original folder with its files at:
```
[Install Directory]\saves\CreateBlueprint\Blueprint\-1476558188 - the folder
[Install Directory]\saves\CreateBlueprint\Blueprint\-1476558188\Content.json - the data
[Install Directory]\saves\CreateBlueprint\Blueprint\-1476558188\-1476558188.png - the preview image
```
Will need to be migrated to the mod, resulting in:
```
ACS_M_EX_09\Blueprint\-1476558188
ACS_M_EX_09\Blueprint\-1476558188\Content.json
ACS_M_EX_09\Blueprint\-1476558188\-1476558188.png
```

## Polishing

Apart from the typical info.json content, the only possible modifications are preview image modification, and Content.json additions.

### Preview Image modification

A simple `BP_ID.png`, adding watermarks or logos, you can do whatever you want with it. A minor modification has been done as an example.

### `Content.json` additions

There are two values that can be easily modified. The DisplayName, and the Description. When the blueprint has special usage requirements, adding that information to the description is a sensible choice.

## Publishing and usage

To prepare the mod for publishing, make an archive containing the mod folder (ACS_M_EX_09). The mod is now ready for publishing.

To install the mod, extract the archive to the local Mods folder just like any other mod.

**However**, due to the mod being created outside of the Realms Palace constraints and aspects, there's one major difference with typical blueprint mods found on the workshop:

>**Externally created blueprint mods show up under the Mods list, and need to be manually activated.**

This also means that they can be removed/disabled without having to unsubscribe/delete the files. Something that is not possible with Realms Palace creations.