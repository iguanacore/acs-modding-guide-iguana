# ThingDef

This document is about ThingDefs, and the ways they are utilized. ThingDefs are just like the namy says, Things. This includes Items, Buildings, Plants, even Areas or NPCs.

ThingDefs are defined under Settings\ThingDef, and within XML files. An extremely minimal example is below:
```xml
<ThingDefs><List>
	<ThingDef Type="CMD" Name="CMDThing">
	<SelectAble>0</SelectAble>
	<VisualAble>0</VisualAble>
	</ThingDef>
</List></ThingDefs>
```
Below is a list of general attributes found in ThingDefs. When in doubt, check existing examples of how things might be done.

A lot of things remain to be specified.

## General attributes

These attributes can be utilized with all Types of Things. The listed order is identical to the order they are listed in `XiaWorld.ThingDef` class. Not all attributes are listed, the ones mentioned are those worth explaining in my opinion.

* Name - Internal name, unique
* Parent - The Parent ThingDef, used to inherit attribute values, lessens duplication.
* Type - Type of ThingDef, possible values are found `in XiaWorld.g_emThingType`.
    * `None`
    * `Npc`
    * `Item`
    * `Plant`
    * `Building`
    * `Space`
    * `CMD`
* Disable - Used to disable the ThingDef when a positive value is set. Not utilized for any existing ThingDefs.
* Frags - List of Yaoguai Shards gained by observing the ThingDef.
* TonglingHair - Hair Style used when the ThingDef is illuminated and given a body.
* ClassName - Class of the ThingDef, used together with lua scripts. 
* Rate - Tier of the ThingDef.
* Tags - Tags for the ThingDef. A list of existing tags can be found below.
* MaxStack - Maximum stack size.
* TileID - Used to set a tile for rendering. When in doubt, check other similar ThingDefs.
* ColorTxt - Color for the ThingDef, commonly found in items. Utilized a HTML string for color.
* TexScale - Scale for the ThingDefs Texture.
* TexPath - Path for the ThingDefs Texture.
* FabaoTexPath - Path for the Texture when the ThingDef is used as a base for an Artifact. Commonly found with Legacy Artifacts.
* ModPath - Model for the ThingDef, used with Ancient Beast cores.
* Desc - Description for the ThingDef, shown in game.
* ModScale - The scale of the Model for the ThingDef.
* ThingName - Name of the ThingDef shown in game, similar to DisplayName.
* NoElementKind - A positive value is used to force the item and all its children to None element.
* ElementKind - If `NoElementKind` isn't set, this sets the Element for the item. Possible values (from `g_emElementKind`) are:
    * `None` - None
    * `Jin` - Metal
    * `Mu` - Wood
    * `Shui` - Water
    * `Huo` - Fire
    * `Tu` - Earth
    * `Chaos` - Chaos
* SelectAble - A positive value is used when the ThingDef can be selected.
* VisualAble - A positive value is used when the ThingDef can be seen.
* CastShadow - A value of 1 is used when the ThingDef casts a shadow.
* ShadowSize - The size of the ThingDef shadow, consists of a Vector, with an X and a Y value.
* VisionRadius - The distance of area revealed through the fog of war by the ThingDef. Can also be understood as the vision granted by the ThingDef.
* BindWeather - The weather introduced when the ThingDef exists. Rainmaker (the sword, `SP_Sword2`) is one example with `MuYu_LightRain`, Fei and Lushu are another.
* Beauty - Attractiveness value of the ThingDef.
* UseHitPoints - A value of 1 is used when the ThingDef utilizes HitPoints. 0 is used for indestructible ThingDefs.
* MaxHitPoints - Maximum amount of HitPoints, when the ThingDef utilizes HitPoints.
* GrowAble - A value of 1 is used with plants when the ThingDef can grow over time. 0 is used for anything else.
* NotDoTongLing - A value of 1 disables illumination for the ThingDef. This includes both player controlled methods as well as random methods.
* LingMin - Not to be confused with other similarly named attributes. This is the minumum amount of Qi a ThingDef can posess. Not utilized.
* LingMax - Not to be confused with other similarly named attributes. This is the maximum amount of Qi a ThingDef can posess. Utilized with Tribulations and Boss corpses/buildings.
* Flammability - The `FlammabilityData` of a ThingDef, pretty self explanatory. Consists of the follow attributes:
    * `Flammability` - How flammable the ThingDef is, a negative value is used
    * `FlameSpawnChance` - The chance of the ThingDef spawning a flame on death. A value of 1 will mean a 100% chance.
    * `BurningPoint` - The temperature when the ThingDef starts burning. Similarly for other temperature related values, it's referring to Celsius.
* Item - The `ItemData`, used for Item Type ThingDefs. A detailed list is below.
* Plant - The `PlantData`, used for Plant Type ThingDefs. A detailed list is below.
* Building - `TheBuildingData`, used for Building Type ThingDefs. A detailed list is below.
* Npc - The `NpcData`, used for Npc Type ThingDefs. A detailed list is below.
* Ling - The `LingData` of the ThingDef, or Qi related attributes. A detailed list is below.
* Element - The `ElementData` of the ThingDef, or Element related attributes. A detailed list is below.
* Harvest - The `HarvestData` of the ThingDef, or Harvest related attributes. A detailed list is below.
* Light - The `LightData` of the ThingDef, or Light related attributes. A detailed list is below.
* Heat  - The `HeatData` of the ThingDef, or Heat related attributes. A detailed list is below.
* Fertility - The `AuraData` or the ThingDef, or Fertility related attributes. A detailed list is below.
* BlockLight - A value of 1 is used when the ThingDef blocks light.
* BlockMissile - A value of 1 is used when the ThingDef can block Missiles. This includes artifact as well as spells.
* StoryBnts - The `MenuData` of a ThingDef, used for additional interactions with the ThingDef. The `MenuData` can consist of the following attributes:
    * `Name` - Name of the Button
    * `Desc` - Description shown when hovering over the Button
    * `Story` - Triggered `MapStory` when the Button is selected
    * `Cost` - Amount of time the interaction takes place
    * `Ani` - Animation used for the interaction
    * `Place` - Used to assign a Place value for the Story, not utilized in any examples
    * `Icon` - Path to Icon of the Button
    * `Appoint` - The Disciple set to interact, 0 chooses the Disciple at random, 1 to select an Outer Disciple, 2 to select an Inner Disciple, 3 to select any Disciple (like Ancient Caskets)
    * `Script` - Script triggered, examples can be seen with Spirit Seeds and Spirit Fruits
    * `StoryScript` - Lua script triggered in place of the Story
    * `Scope` - A value of 0 (default) is used when the Button is active on the local map. A value of 1 is used for FightMaps, a value of 2 is used for PlantBoxes (including corpses on maps).
    * `WorldFlag` - A `g_emWorldFlag`, possible values:
        * `None`
        * `Magic_Prophesy`
        * `Boss_FinishJiaoLong`
        * `Boss_FinishXiongFeng`
        * `Boss_FinishZhuLong`
        * `DaNeng_Begin`
        * `Portia_Activity`
        * `StoryXif`
        * `EatJiaozi`
        * `ZhuLongSP`
        * `SP_Event`
        * `DiMuBuildingEvent1`
        * `DiMuBuildingEvent2`
        * `LongWarning`
        * `FinaleActive`
        * `FinaleFinish`
        * `FinaleNotice`
* ProduceMode - The `ProduceModeData` of a ThingDef, or Production related attributes. A detailed list is below.
* ColliderKind - The type of Collider, as listed in `g_emColliderKind`, not utilized, possible values:
    * `None`
    * `Open`
    * `Slow`
    * `Accross`
    * `ThrowOver`
    * `NoPass`
* IllustratedHandLabel - Category used with the `IllustratedHand` (codex, from what I've gathered), possible values:
    * `None`
    * `Dan`
    * `Baowu`
    * `Treasure`
    * `Spell`
    * `Curiosity`
    * `FSItem`
    * `DOther`
    * `Equip`
    * `Food`
    * `Material`
    * `WOther`
    * `Gong`
    * `ShangGuZhen`
    * `SlotSuit`
    * `Magic`
    * `Animal`
    * `JYAnimal`
    * `Boss`
    * `LSAnimal`
    * `YsAnimal`
    * `Building`
    * `Plant`
    * `Weather`
    * `School`
    * `Place`
    * `MapStory`
    * `Practice`
    * `NaturalWonders`
    * `Fish`
    * `Dele`
* Collider - The `ThingColliderData` of a ThingDef, or the Collider of a ThingDef. A detailed list is below.
* EggCondition - The `EggBirthCondition` of a ThingDef, or requirements for Egg Growth. Can consist of the following attributes:
    * `TempMin` - Minimal required temperature for Egg growth. Won't grow if temperature is below this value.
    * `TempMax` - Maximum required temperature for Egg growth. Won't grow if temperature is above this value.
    * `LingMin` - Minimal required Qi on tile value for Egg growth. Won't grow if Qi on tile is below this value.
    * `LingMax` - Maximum required Qi on tile value for Egg growth. Won't grow if Qi on tile is above this value.
    * `LightMin` - Minimal light level required for Egg growth. Won't grow if light level is below this value.
    * `LightMax` - Maximum light level required for Egg growth. Won't grow if light level is above this value.
    * `ElementKind` - Standard Element types, as seen in `g_emElementKind` listed above.
    * `ElementPower` - Required Elemental Power for the previously listed element.
* FrameStep - Used with the Phoenix egg, a value of 1 will add the Thing without Npc Frame. Exact usage to be specified in the future.
* KeepModelColor - A value of 1 is used to retain the original color when a Material is used which may have a different Color value.
* HideRoof - A value of 1 is used with Walls, to hide the default Roof types. Used with WuDang Red Walls.
* OtherWorld - A value of 1 is used for Things created with the Realms Palace Content Editor.
* DownMod - A value of 1 is used for Things created with the Realms Palace Content Editor.
* HideInOtherWorld - A value of 1 is used to hide the ThingDef from Realms Palace

## ItemData

Used with `Item` Type ThingDefs. Consists of the following attributes:

* `Kind` - A `g_emItemKind`, possible values are:
    * None
    * Material
    * Equipment
    * Consumable
    * Practice
    * Count
* `Lable` - A `g_emItemLable`, possible values are:
    * None
    * Wood
    * WoodBlock
    * Rock
    * RockBlock
    * Metal
    * Plant
    * PlantProduct
    * Ingredient
    * Meat
    * Leather
    * Cloth
    * Bone
    * Weapon
    * FightFabao
    * TreasureFabao
    * Hat
    * Clothes
    * Trousers
    * Food
    * Drug
    * Dan
    * Spell
    * Tool
    * MetalBlock
    * Esoterica
    * LeftoverMaterial
    * SpellPaper
    * LingStone
    * Garbage
    * SoulCrystal
    * Treasure
    * Influence
    * SPStuffCategories
    * BambooBlock
    * Cape
    * Horse
    * Other
* `CustomKind` - Not implemented.
* `BeMaterial` - The ItemDataBeMaterial of an Item. More details below.
* `BeMade` - The ThingBeMadeData of an Item. More details below.
* `NotRandom` - Used to disable the Item from spawning randomly (in the inventory of a NPC for example).
* `Rot` - The RotData of an Item. More details below.
* `Food` - The FoodData of an Item. More details below.
* `Drug` - The DrugData of an Item. More details below.
* `Elixir` - The ElixirData of an Item. More details below.
* `Equip` - The EquipData of an Item. More details below.
* `NoHelian` - Used to disable the Item from accepting Sub-Spirits. Example: Contracts
* `Fengshui` - The FengshuiItemData of an Item. More details below.
* `Fabao` - The FabaoItemData of an Item, used with Legacy Artifacts. More details below.
* `Fish` - The FishData of an Item. More details below.
* `FuelMultiplier` - The Fuel Multiplier of an Item. Used to increase the duration of fueling time for buildings when the item is used as fuel.
* `IsWater` - Whether an Item can be categorized as Water. TBS
* `PhysicalLables` - The PhysicalLables of an Item, used for Artifact stats.
* `DevourDatas` - The `DevourData` of an Item, or the Essences provided when devouring the Item by a Physical Cultivator. Consists of the following attributes:
    * `Name ` - Internal Name of Essence 
    * `Count` - Amount of Essence granted
    * `Rate` - Chance of acquiring the Essence listed
* `FabaoSuffix` - The suffix of an Artifact created from the Item.
* `NotFengshuiItem` - Used to disable the Item from becoming a Relic.
* `LingPlantName` - Not implemented.
* `UseLua` - Lua code triggered when the Item is used. Certain Legacy Artifact activation conditions go under this attribute.
* `Prices` - The TradeItemPrices of an Item. Consists of the following attributes:
    * `TalkType` - Message used by Trader when the item is selected.
    * `BaseCount` - Amount of Items posessed by Trader by default.
    * `Fixed` - Seems to be a whether the Item is a definite entry within the Traders inventory.
    * `Prices` - The actual Buying and Trading Prices of an Item. Consists of the following attributes:
        * `PriceTag` - Either School (Sect trades), Trade (Merchant trades), or Auction
        * `BuyPrice` - Buying Price value in Spirit Stones
        * `SalePrice` - Selling Price value in Spirit Stones

### ItemDataBeMaterial


### ThingBeMadeData


### RotData


### FoodData


### DrugData


### ElixirData


### EquipData

Used for equipment. Can consist of the following attributes:

* AtkDamage
* EquptData
* AttackSkill
* AttackSpeed
* AttackRange
* Damage
* ArmorLingShield
* TemperatureMaxAdd
* TemperatureMinAdd
* PropertyScaleFromStuff
* ToolModifier
* Modifier
* EwaponKind
* AtkAnis
* ModelID
* ModPath
* NpcMod
* NeedSex
* HorseData
* CapeData

### FengshuiItemData

Used for Relics. Can consist of the following attributes:

* `AddV` - Amount of Auspiciousness added to the Room Auspiciousness.
* `ElementKind` -  - Element of Relic.
* `ElementPower` - Required Element Power (listed in `ElementKind`) for the Relic.
* `RoomKind` - A `g_emRoomKind` value, Room type requirement. Possible values:
    * None
    * BedRoom
    * AncestorRoom
    * WorkRoom
    * BaoRoom
    * DanRoom
    * Kitchen
    * StorageRoom
* `RoomLevel` - Room Size, 5 for Huge (100+), descending values with 0 for No size requirement.
* `Localtion` - A `g_emFengShuiItemLocal` value, the location requirement for the Item. Possible values:
    * None
    * Corner
    * CornerThre
    * StickingWall
    * DontStickingWall
    * BesideDoor
    * The following are special location values:
    * BesideBedRoom
    * BesideAncestorRoom
    * BesideWorkRoom
    * BesideBaoRoom
    * BesideDanRoom
    * BesideKitchen
    * The following are negative special location values:
    * DnotBesideBedRoom
    * DnotBesideAncestorRoom
    * DnotBesideWorkRoom
    * DnotBesideBaoRoom
    * DnotBesideDanRoom
    * DnotBesideKitchen
* `RoomFengshui` - A `g_emFengShuiRank` value for the room. Not utilized with any existing relics.
* `Specials` - Special Activation Conditions.
* `Modifiers` - Modifiers applied, also listed as Spirit Relic Effects.
* `ModifierScale` - Scale of the modifiers applied.

### FabaoItemData

Used with Legacy Artifacts, their Activation Conditions and Special Abilities. For more details on condition, check existing usage in the files. TBS

Activation Conditions (`FabaoActiveData`), or `ActiveCondition`, are the conditions to activate a Legacy Artifact incubation, which can consist of the following attributes:

* `eventid` - The Event Type, as listed in `FabaoEvenType`, possible values:
    * None
    * KillCount
    * SoulCrystalYou
    * SoulCrystalLing
    * SoulCrystal
    * Carry
    * UseNpcJing
    * UseNpcLing
    * BrokenNeck
    * BrokenNeckElement
    * RefiningDan
    * MapStay
    * Trance
    * Other
* `des` - Description of the condition, listen in game.
* `needcount` - Amount of Events required to fulfill condition.
* `needday` - Amount of Days needed for the condition.
* `oParam` - Target Race (used with KillCount EventID), TBS
* `lParam` - Target Stage requirement (used with KillCount, BrokenNeck)
* `sParam` - Target Map (used with MapStay)
* `fParam` - Refining success (SoulCrystal types), GC Tier (BrokenNeck types), Success with Alchemy (RefiningDan types)
* `tParam` - Time frame required for condition.
* `tParam2` - Time frame required for condition.
* `tParam3` - Time frame required for condition.
* `eParam` - Element Parameter.
* `sex` - Gender requirement for condition.
* `age` - Age requirement for condition.
* `continuity` -  Whether the condition needs to be done in a single go.

Special Abilities (`FabaoSpecialAbility`), or `SpecialAblity`, are the Legacy Artifact special effects, which can consist of the following attributes:

* `Kind` - Type of Special Ability, listed in `g_emFabaoSpecialAbility`. Possible values:
    * `None`
    * `HitCountAddDamage`
    * `FlyDamageAddP`
    * `HitCountCostSkill`
    * `CantAttack`
    * `AtkRateDamageAddp`
    * `HitSameFabaoAndEffect`
    * `HitCountAddMirror`
    * `HitAddRecovery`
    * `FunctionEffectPower`
    * `HitCountAddSubColdDown`
    * `MultiKillAddPowerUp`
    * `DanCountAddPowerUp`
    * `Sync_AddFlag`
    * `Sync_AddEquptData`
    * `Sync_AddEquptDataModifier`
    * `AgeAddPowerUp`
    * `FristHitPowerUp`
    * `LastLingCostPowerUp`
    * `DaoHangDamageUp`
    * `NotRaceDamageUp`
    * `RaceEquipDamageUp`
* `nParam1` - First Parameter (Integer)
* `nParam2` - Second Parameter (Integer)
* `fParam1` - First Parameter (Float)
* `fParam2` - Second Parameter (Float)
* `sParam1` - First Parameter (String)
* `sParam2` - Second Parameter (String)
* `Desc` - Description of Special Ability

### FishData

Used with Fish. Consists of the following attributes:

* `BaseWeight` - The Base Weight value for the Fish.
* `LevelAmp` - Used as a factor for Fish Tier, together with its weight value.
* `Weight` - The Weight value for the Fish.
* `Season` - Required Season, a `g_emSeason`, for Fishing, possible values are:
    * None
    * Spring
    * Summer
    * Autumn
    * Winter
* `RodElement` - Required Fishing Rod element (from `g_emElementKind`) for Fishing.
* `NeedWeather` - Required Weather for Fishing.
* `Precious` - Used to set whether the Fish is a Valuable/Big Fish.
* `MapName` - Required (Fight) Map for Fishing.
* `WaterName` - Required Water type for Fishing.
* `FishTimes` - Required Time of Day for Fishing.

## PlantData

Used with `Plant` Type ThingDefs (TBS). Consists of the following attributes:

* `Kind` - A `g_emPlantKind`, possible values are:
    * None
    * HighPlant
    * LowPlant
    * Mine
    * Object
* `CanMakeRoom` - A value of 1 is used when the ThingDef can be utilized as a Wall-like object. Example: Ores
* `WildClusterSizeRangemin` - Used with the Map Maker, the smallest size of a randomly generated cluster.
* `WildClusterSizeRangemax` - Used with the Map Maker, the largest size of a randomly generated cluster.
* `WildClusterRadius` - Used with the Map Maker, the radius of a randomly generated cluster.
* `RipedTexPath` - Path to texture used for a Ripe (mature) Plant.
* `HarvestedTexPath` - Path to texture used for a harvested Plant.
* `LeaflessTexPath` - Path to texture used for a leafless Plant, TBS.
* `SnowedTexPath` - Path to texture used for a snow covered Plant, TBS.
* `GlowTexPath` - Path to texture used for GlowPlants (plants with a blue glow).
* `TexLing` - The `LingTex` attributes of a Plant, used with Spirit Roots, consists of the following attributes:
    * GrowTex1
    * HarvestTex0
    * HarvestTex1
    * HarvestTex2
* `SnowRenderData` - A vector with 3 components, used to display snow.
* `VisualSizeMin` - The minimal visual size of the Plant.
* `VisualSizeMax` - The maximum visual size of the Plant.
* `SowWork` - Amount of time required to plant the Plant.
* `SowPlaceKind` - A g_emTerrainType, used to restrict where the Plant can be planted. Possible values:
    * None
    * Ground
    * DepthWater
    * ShallowWater
    * Floor
    * Water
    * GroundShallowWater
    * All
* `SowPlaceTag` - A string, used to restrict where the Plant can be planted. Used together with the TerrainDef TagData.
* `SowRenderTags` - TBS, existing values can be found with Tree and plant.
* `LifespanFraction` - The LifeSpan of a Plant.
* `GrowDays` - Amount of days required for the Plant to reach 100% Growth, base value.
* `HarvestDays` - Amount of days required for the Plant to reach 100% Maturity, base value.
* `ReproduceRadius` - Range which the Plant can reproduce, or spawn branches.
* `RestBegin` - Starting time of Resting period. Used to limit planth growth by time of day.
* `RestEnd` - Ending time of Resting period. Used to limit planth growth by time of day.
* `WitherAble` - Whether the Plant can be withered by the season.
* `WitherDestroy` - Whether the Plant can be hidden (or destroyed) by the season.
* `DecidiousLeafInAutumn` - Whether the Plant leaves have a different color in Autumn.
* `NoDissapear` - Whether the Plant dissapears when withering.
* `TempMin` - Minimal required temperature for Plant growth.
* `TempMax` - Maximum required temperature for Plant growth.
* `LingMin` - Minimal amount of Qi on tile required for Plant growth.
* `LingMax` - Maximum amount of Qi on tile required for Plant growth.
* `FertilityMin` - Minimal amount of tile fertility required for Plant growth.
* `FertilityMax` - Maximum amount of tile fertility required for Plant growth.
* `GrowGlowMin` - Minimal Amount of Light on tile required for Plant growth.
* `GrowGlowMax` - Maximum Amount of Light on tile required for Plant growth.
* `WindEffect` - How much the Plant is affected by wind, used in rendering.
* `ElementRange` - Amount of Element power required for growth, consists of an `ElementNeed` list, each entry consists of the following attributes:
    * `ElementKind` - (from `g_emElementKind`)
    * `Min` - Minimal elemental strength
    * `Max` - Maximum elemental strength
* `LingShaSpeed` - TBS, used with Spirit Roots.
* `YunYangInterval` - TBS
* `LingZhiR` - The radius used when planting, TBS
* `JiaGanModifierGT0` - Modifier added with Sympathy, used with Blessed Plants.
* `JiaoGanModifierLT0` - Modifier added with Sympathy, used with Cursed Plants.
* `BaseLingCost` - A factor in calculating Qi cost for growth, used with Spirit Roots.
* `LingShaSpeedCoefficient` - Blessed and Cursed factor change coefficient, used with Spirit Roots.
* `PlantSeed` - A ThingDef, used with Illumination and Sentient Spirit. Example use with Spirit Roots.
* `NotRandom` - A positive value removes the plant from randomly spawning.

## BuildingData

Used with `Building` Type ThingDefs (TBS). Consists of the following attributes:

* `AutoUnlock` - 
* `Perfab` - 
* `MaxCount` - 
* `HelperClass` - 
* `BuildMode` - 
* `ShowFree` - 
* `OwnerCount` - 
* `IsDoor` - 
* `IsWall` - 
* `IsBed` - 
* `CanMakeRoom` - 
* `LeaveResourcesWhenKilled` - 
* `TerrainAffordanceNeeded` - 
* `RemovePriceFactor` - 
* `BePackage` - 
* `IsVirtualBuilding` - 
* `DontRemoveVirtual` - 
* `VAddToMap` - 
* `FloorDefName` - 
* `IsRoof` - 
* `NoColor` - 
* `SpringFlag` - 
* `IsFloor` - 
* `WorkTexPath` - 
* `MaxWorker` - 
* `RestEffectiveness` - 
* `BasePracticeEffectiveness` - 
* `PracticeEffectiveness` - 
* `WorkAnimation` - 
* `NoFight` - 
* `NoFengshui` - 
* `NotDemolished` - 
* `BagDrop` - 
* `Produces` - 
* `ProduceKind` - 
* `ProducePriority` - 
* `SelectProduceStuff` - 
* `BeMade` - 
* `Drive` - 
* `WoodTexPath` - 
* `SnowRenderData` - 
* `RoomKind` - 
* `FillTarrain` - 
* `OrientationTxt` - 
* `NotRandom` - 
* `WorkModifier` - 
* `AutoOrientation` - 

## NpcData

"Used" with `Npc` Type ThingDefs. Empty, not implemented in XiaWorld..

## AuraData

Mainly used for Fertility, but the structure is similar to other emitting types. Consists of the following attributes:

* `Value` - Strength of Aura emitted.
* `Radius` - Distance of Aura emitted.
* `Failing` - Rate of the decay of Aura. A value of 1 means no decay.
* `FailRadius` - Distance when Aura starts decaying.
* `SkipSelf` - When set to 0 can be utilized to stop the effect from being added. Need to verify.

## LingData

Qi related attributes. Somewhat similar to AuraData, consists of the following attributes:

* `AddionLing` - Strength of Qi Gathering emitted.
* `AddionRadius` - Distance of Qi Gathering emitted. Also used to affect the Qi gathering resetting when placed/replaced.
* `AddionFailing` - Rate of the decay of Qi Gathering emitted. A value of 1 means no decay.
* `AddionFailRadius` - Distance when Qi Gathering starts decaying.
* `Attenuation` - Attenuation of the ThingDef, influences the Ambient Qi value.
* `Absorption` - Absorption of the ThingDef, influences the rate of Qi a ThingDef can absorb.
* `Accommodate` - Accommodation of the ThingDef, influences the amount of Qi a ThingDef can absorb.
* `LingSource` - Directly generates Qi. Used with Spirit Veins.
* `LingNum` - Currently only used with NPCs. Need to verify (TBS).
* `LvUpNeedLing` - Not functional, but exists as a parameter (TBS).
* `SkipSelf` - When set to 0 can be utilized to stop the effect from being added. Need to verify.

## ElementData

Element emitting related attributes. Based off AuraData, consists of the following attributes:

* `Kind` - Element type, possible values are listed in `g_emElementKind` (explained above).
* `Value` - Strength of Aura emitted.
* `Radius` - Distance of Aura emitted.
* `Failing` - Rate of the decay of Aura. A value of 1 means no decay.
* `FailRadius` - Distance when Aura starts decaying.

## LightData

Light related attributes. Based off AuraData, consists of the following attributes:

* `Value` - Strength of Light emitted.
* `Radius` - Distance of Light emitted.
* `Failing` - Rate of the decay of Light. A value of 1 means no decay.
* `FailRadius` - Distance when Light starts decaying.
* `SkipSelf` - When set to 0 can be utilized to stop the effect from being added. Need to verify.
* `Color` - Color of the Light, uses a HtmlString for format.

## HeatData

Temperature related attributes. Based off AuraData, consists of the following attributes:

* `Value` - Strength of Temperature emitted. Positive value for heat, negative for cold.
* `Radius` - Distance of Temperature emitted (when outside).
* `Failing` - Rate of the decay of temperature emitted (when outside). A value of 1 means no decay.
* `FailRadius` - Distance when temperature starts decaying.
* `SkipSelf` - When set to 0 can be utilized to stop the effect from being added. Need to verify.
* `RoomValue` - Amount of temperature changed when the ThingDef is within a room.
    * The precise formula is: ` RoomValue * 25 / (Amount of Tiles in Room) * Failing * Failing `
    * The Formula is different when it's made out of a Material with HeatData: ` RoomValue * 25 * (Material Count / 4) / (Amount of Tiles in Room) * Failing * Failing `
        * The result for ` (Material Count / 4) ` is always at least 1. 

## HarvestData

Harvesting related attributes. A `HarvestData` can consist of the following attributes:

* `HarvestItems` - A list of `DropItemData`, Things dropped when Harvesting the ThingDef.
* `DropItems` - A list of `DropItemData`, Things dropped when Clearing the ThingDef.
* `HighHarvestItems` - A list of `DropItemData`, Things dropped when Harvesting a GlowPlant ThingDef. No examples in current files.
* `HighDropItems` - A list of `DropItemData`, Things dropped when Clearing a GlowPlant ThingDef. Spiritwood is a popular example.
* `HarvestWork` - Amount of time required to Harvest the ThingDef.
* `DropWork` - Amount of time required to Clear the ThingDef.
* `HarvestValueMin` - Amount of Maturity required for the ThingDef to yield a Harvest.
* `LogValueMin` - Value which seems to be useless (not utilized within XiaWorld).
* `HarvestFailable` - Value which seems to be useless (not utilized within XiaWorld).
* `LinkStory` - A MapStory triggered when the ThingDef is harvested.
* `HarvestTag` - A list of `g_emHarvestTag`, used to assign the proper command for harvesting. Possible values:
    * `None`
    * `SquatCollection`
    * `StandCollection`
    * `Harvest`
    * `Cut`
    * `Dig`
    * `Slaughter`
    * `Open`

DropItemData can consist of the following attributes:

* ThingDef - Name of the ThingDef.
* ThingType - TBS
* Stuff - Main Material of the ThingDef.
* Count - Amount of ThingDefs dropped.
* Condition - An ActionConditon, TBS.
* Rate - Chance of the dropped ThingDef. A value of 1 (default value) guarantees a drop.

## ProduceModeData

Used for Production related attributes (TBS). These are mainly utilized with Realms Palace creations. A ProduceModeData consists of the following attributes:

* InitialUnlock - Whether the Item is unlocked from the start or not.
* DanFormula - Elixir Recipes related to the Item.
* WorldDrop - Whether the Item can be acquired from a random event (like BaseFilling or its derivatives).
* DropCount - The amount of Items dropped
* DropRate - The DropRate of the Item in question.
* Learn - Used together with the Esotericas attribute. Needs to be looked into.
* Esotericas - A string, an Esoterica Name. Needs to be looked into.
* Businessman - A value of 1 is used to add the item to Merchant inventory.
* ProduceBuildings - Consists of a list of ProductData, used with Items to add recipes to Buildings.

A ProductData consists of the following attributes:

* Building - Name of the Building. Internal name, not the ThingName.
* Count - Amount of Items created.

## ThingColliderData

A ThingColliderData is utilized to set collisions, "central tiles" and workspaces. TO BE SPECIFIED(TBS).

## Existing Tags

This is a direct translation of the contents within Settings\ThingDef\Tag说明.txt

### System Tags
* _Rate 记录了物品品阶 - Recorded item rank
* _LableXXXXX 记录了物品的Lable类型 - The Lable type of the item is recorded
* _StoneBox 石匣子 系统特殊道具 - StoneBox System Special Prop
* _LittleRock 小岩快 特殊标记 - Little Rock Fast Special Marker 
* _SysWater 水 不参与统计 - Water does not participate in the statistics
* _FaBao 法宝标记 - Magic Marker
* _Dan 丹药标记 - Potion Markers
* _SHIT 屎标记 - Shit Marker
* _FIRECRACKER 烟花 - Fireworks
* _INCENSE 香火 - Incense
* _YITUI 遗蜕 - Shed skin, or Ascended cultivators remains
* _WONDER 奇观 - Wonders

Definition Tags:

### Buildings
* Apprentice 用于收徒 - For apprenticeship
* ItemShelf 置物台 特殊 - Shelf, Special
* Bury 可用于埋葬 - Can be used for burial
* RefiningDan 可用于炼丹 - Can be used for alchemy
* Refining 可用于炼宝 - Can be used to refine artifacts
* TheGate 可用于拜山门 - Can be used to worship the mountain gate
* ForFun 可用于娱乐 - Can be used for entertainment
* BasePractice 可用于筑基 - Can be used for foundation building
* Sleep 可用于睡眠 - Can be used for sleep
* Practice 可用于修炼 - Can be used for cultivation
* Sitable 可用于坐下 - Can be used for sitting
* AtkPractice 可以作为攻击的练习对象 - Can be used as an attack practice object
* Zhen 阵法 可以收容法宝 - Formation, can hold Magic Treasures (sword shield)
* Puppet 可用于炼制傀儡 - Can be used to make puppets
* WriteTxt 可以撰写内容 - Content can be written (like Steles)
* Zhong 警钟 - Alarm bell

### Items
* Water 可用于饮用(口渴) - Can be used for drinking (thirst)
* Food 可用于食用(饥饿) - Can be used for food (hunder)
* PracticeFood 可用于食用(精元) - Can be used for food (essence element)
* Drug 可用于普通治疗 - Can be used for general treatment
* BowlFood 端着碗吃的食物(表现用) - Food eaten with a bown in the end (for performance)
* CarryHold 搬运的时候抱着走(表现用) - Held while carrying away (for performance)
* DiscipleFood 内门食物优先级 - Inner door food priority
* BookShelf 书架 特殊 - Bookshelf, special