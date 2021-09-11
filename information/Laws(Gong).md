# Laws (Gong)

This document is about laws, internally called `Gong`. Gongs are found under Settings\Practice\Gong, two subdirectories for Physical (Body) and Shendao (God) cultivaiton. Each XML is a single Law, although a single XML can contain multiple Gongs. Taking the Lost Gong as an example, each XML consists of `<Gongs>` and a `<List>` of them, each entry is a single Gong.
```xml
<Gongs><List>
	<Gong Name="Gong_LOST">   <!-- 错误的功法-->  
		<DisplayName>错误的功法</DisplayName>
		<Desc>失落之物，没有人认识这个。\n（模组丢失）</Desc>
		<SelectDesc></SelectDesc>
		<FiveBaseNeed>-1,-1,-1,-1,-1</FiveBaseNeed>
		<SkillSetName></SkillSetName>
		<ElementKind>None</ElementKind>
		<Hide>3</Hide>
		
		<IllustratedHandLabel>Dele</IllustratedHandLabel>
		<Stages>
			<Stage Name="Stage1" Level="1">
				<DisplayName>错误</DisplayName>
				<Value>1</Value>
				<Necks>
					<Neck Location="1" Kind="Die">
						<DisplayName>错误</DisplayName>
					</Neck>
				</Necks>
			</Stage>
			<Stage Name="Stage1" Level="12">
				<DisplayName>错误</DisplayName>
				<Value>1</Value>
				<Necks>
					<Neck Location="1" Kind="Die">
						<DisplayName>错误</DisplayName>
					</Neck>
				</Necks>
			</Stage>
			
		</Stages>
	</Gong>
</List></Gongs>
```
- Name - Internal identifier for the Gong, must be unique.
- DisplayName - The name of the Gong, displayed in-game.
- Desc - The description of the Gong, displayed in-game.
- SelectDesc - A message box is displayed when you attempt to promote a disciple, this is the contents of that message box.
- FiveBaseNeed - The Base stat requirements for the law.
- SkillSetName - Not used, leave it as it is.
- ElementKind - The element of the Gong, usual values apply here.
- Hide - Whether the Gong is hidden or not. The basic Gongs don't have the value, advanced Xiandao and Physical Gongs have it set to `1`, Shendao Gongs have it set to `2`, hidden Gongs not meant to be used have it set to `3`.
- IllustratedHandLabel - Set to `Dele` for the Gongs not meant to be used, not set for other Gongs.
- Stages - Constains the Stages for the Gong. Check below for more details.

These are the common properties for Gongs.

## Xiandao Gong specialities

For Xiandao Gongs, there are two properties specific for them.

- YinYang - The unique Yin Yang mechanic, used with the new DLC Gong, a value of 1 sets it into a Yin Yang Law.
- Skill - Used in two places, the assigning the Immortal Mortal Body miracles, and with Branch leader method bonus.

List of Skills ingame:

Skill|Miracle at the statue|Description of the miracle
-|-|-
`Chumo`|Exorcise|Costs 49 Incense. The master will come down to earth to fight for one day.
`Jiangdao`|Land|Costs 49 Incense. The master will come down to earth to give a lecture for one day. Inner disciples will attend the lecture standing or sitting on nearby cushions.
`Guanding`|Enlighten|Costs 9 Incense. Enlightens one disciple by immediately granting them 50k Inspiration XP.
`Ciqi`|Bestow|Costs 25 Incense. Gain a gift from the master.
`Kaiguang`|Consecrate|Costs 25 Incense. Increases an item's tier by 1-4 levels, but cannot raise an item above tier 12.
`Cuiti`|Remold|Costs 25 Incense. Cures all illnesses, restores all organs, and improves the five senses for an outer disciple.
`Bihu`|Protect|Costs 9 Incense. Clears all weather effects and grants protection.

## Shendao Gong specialities

For Shendao Gongs, there are a few specific properties.

- GongKind - `God` for Shendao Gongs, not set for Xiandao Gongs.
- Skill - Similar function as the Xiandao Skill property, but set to `hufaciyu` for all Shendao Gongs, provides the miracle to grant guards for other Shendao.
- GodGuards - The default Guards that a Divine Realm Shendao has access to. Can have multiple entries, each entry is a single guards.
- Magic - The default Miracles a Shendao starts with. Can have multiple entries, each entry is a single miracle.

## Physical Gong specialities

For Physical Gongs, there are a few specific properties.

- GongKind - `Body` for Physical Gongs, not set for Xiandao Gongs.
- SuperParts - The Secret Bodies a Physical cultivator starts with. Can have multiple entries, each entry is a single Secret Body.
- QuenchingMethods - The remolding methods a Physical cultivator starts with. Can have multiple entries, each entry is a single method.
- Magic - The default Miracles a Physical cultivator starts with. Can have multiple entries, each entry is a single Mmiracle.

## Stages

All the Gongs consists of stages. This relates to the stage of cultivation. The above example law contains two stages. A stage has the following properties:

- Name - Internal identifier for the Stage, the first stage is `Stage1`, second is `Stage2` and so on.
- Level - The level for the Stage. A number between 1 and 12. Taking the Random Gongs as an example, the numbers correspond to certain stages:

Level|Stage Name|Xiandao Stage|Shendao Stage|Physical Stage
-|-|-|-|-
1|Tempered|Qi Shaping|Ascetic State|Remold Phase
2|Concentrated|Qi Shaping|Ascetic State|Remold Phase
3|Shaper|Qi Shaping|Ascetic State|Remold Phase
4|Mind Gate|Core Shaping|Pilgrim State|Marrow-cleansing Phase
5|Cauldron|Core Shaping|Pilgrim State|Marrow-cleansing Phase
6|Essence Shaper|Core Shaping|Pilgrim State|Marrow-cleansing Phase
7|Golden Core|Golden Core|Divine State|Incubation Phase
8|Alchemy|Golden Core|Divine State|Incubation Phase
9|Embryonic|Golden Core|Divine State|Incubation Phase
10|Origin Incubation|Primordial Spirit|Attainment State|Chaos Phase
11|Spirit Soaring|Primordial Spirit|Attainment State|Chaos Phase
12|Primordial Spirit|Primordial Spirit|Attainment State|Chaos Phase

- DisplayName - The name for the Stage, displayed in-game.
- Desc - The description for the Stage, displayed in-game.
- Value - The amount of XP (cultivation) in the stage. This is the value needed to reach the end of the Stage.
- Necks - The breakthroughs, or Necks.

### Necks

A stage can have multiple Necks, each Neck has its own set of properties. The example at the top contains a minimal example. A Neck has the following properties:

- Name - Name of the Neck, not used.
- Location - The location of the Neck in the stage. Relates to a percentage of the entire stage value, `1` is at the end of the stage, `0.5` is at half point, and so on.
- Kind - Type of the Neck. The possible types:

Kind|Description
-|-
None|Not used
Chance|Regular chance based breakthrough, most common type
Explore|Adventuring breakthrough
Work|Void Breakthrough, turn into an Outer for some time
Gold|Golden Core forming breakthrough
Thunder|Tribulation
God|Ascension Tribulation, after this they're a Demi-God
GodCity|Divine Realm forming breakthrough
FuPractice|Innate Talisman drawing breakthrough, a Primordial Symbols Law unique mechanic
Die|Passing over, like at the end of Physical Gongs.

- DisplayName - The name of the Neck, displayed in-game.
- Desc - The description for the Neck, displayed in-game.
- Value - An integer, set to 100 by default, not used.
- Story - Used with Explore Necks, sys_brokenneck by default.
- SuccessChange - Used with Chance Necks, a string value, referencing the GongProperties found in `GongProperty.xml`, influences the breakthrough chance.
- FailedChangeAdd - Used with Chance Necks, a string value, either references one of the GongProperties or a specific value (float).
- ExploreValue - Used with Explore Necks, a higher value increases the amount required for a successful breakthrough.
- ThunderValue - Used with all tribulation Necks, sets the base strength for the Tribulation.
- NeckCountdown - Used with all tribulation Necks, sets the countdown for the Tribulation.
- CostTime - The duration for the Neck, default value at 10.
- ItemCost - A required item for the Neck, consists of the Item. An example from SSS:
```xml
<ItemCost>
    <Item name="Item_Dan_SwordBall"/>
</ItemCost>
```
- ResourceCost - A required Resource for the Neck, the kinds are from `XiaWorld.g_emPracticeResourceType`. An example from Heaven Stealing Law:
```xml
<ResourceCost>
    <Resource kind="Age" value="5"/>
</ResourceCost>
```
- Damages - Possible received damages when failing the Neck. Consists of PartKind (XiaWorld.g_emBodyPartKind), PartName (String), Name (String), Rate (Float, default 1), and DescTags (String).
- AddMaxAge - Possible to increase lifespan by breaking through a BottleNeck, uses a Float.
- AddLingMax - Possible to increase Max Qi by breaking through a BottleNeck, uses a Float.
- AddPracticeNeed - Possible to increase Stamina by breaking through a BottleNeck, uses a float.
- AddLingAbsrorbSpeed - Possible to increase Qi Recovery by breaking through a BottleNeck, uses a Float.
- AddEsotericaMax - Possible to increase Manual limit Property by breaking through a BottleNeck, uses an Int.
- AddModifier - Possible to add a Modifier by breaking through a BottleNeck, uses a String for the Modifier name.
- FailModifier - Possible to add a Modifier by failing the BottleNeck, uses a String for the Modifier name.
- Esoterocas - Manuals added after clearing the Neck. Can have multiple entries, each entry is a single Manual. Used with Myriad Artifact Law and Meditation.
- SuperParts - Secret Bodies added after clearing the Neck. Can have multiple entries, each entry is a single Secret Body.
- BodyAttitude - Stances added after clearing the Neck. Not utilized for current Gongs.
- QuenchingMethods - Remold Spells added after clearing the Neck. Can have multiple entries, each entry is a single Remold Spell.