# MapStory Lua

A resource for the MapStory lua functions. Examples can be found in the game files. More information can be found in the multiple LuaHelper classes in Assembly-CSharp.dll

This is not a comprehensive resource of all the functions you can use with MapStories, it’s only a translation for the file in Mods directory.

Scopes used
- me: the current
- story: used with events(Mapstories)
- world: global

## Examples:
Using a method:

    me.AddPracticeResource(2,100);

Example of a property:

    story.School

Empty is represented by:

    nil
 
## me: Scope

Name|Description|Is a Property|Parameter Description|Return Value
-|-|-|-|-
npcObj|npcObject|1||	 	 
GetPhysique|Returns CON||无|Float
GetPerception|Returns PER||无|Float
GetCharisma|Returns CHA||无|Float
GetIntelligence|Returns INT||无|Float
GetLuck|Returns LUK||无|Float
GetSchool|Returns the Sect ID, Player Sect is -1||无|Int
GetAge|Returns Age||无|Float
GetSex|Returns Gender||无|Int（0 None 1 Male 2 Female）
GetMood|Returns Mood value||无|Float
GetGodPenalty|Returns Penalty value (negative for virtue, positive for condemnation)||无|Float
CheckFeature|Checks if the NPC has a feature||String “Feature name”|Bool
GetSkillLevel|Returns Skill level value||emNpcSkillType Skill|Int
GetSkillLove|Returns Skill love (love, or obsession, the Stars)||emNpcSkillType Skill|Int （0 None 1 Love 2 Obsessed）
GetGLevel|Returns the Stage value (0-12)||无|Int
GetGElementKind|Returns the Element for the law||无|Int 0-None 1-Jin-Metal 2-Mu-Wood 3-Shui-Water 4-Huo-Fire 5-Tu-Earth 6-Chaos
GetSchoolScore|Returns Sect Reputation||Int(0 Total Reputation 1 Base Reputation 2 Good Reputation 3 Evil Reputation)|Float
GetSchoolRank|Returns Sect Alignment|| [int] Sect ID，leaving it blank will give you the Player Sect Rank|Int 0 -None 4 -Rank13 3 -Rank12 2 -Rank11 1 -Rank0 -1 -Rank01 -2 -Rank21 -3 -Rank22 -4 -Rank23 0 Unknown 2 3 4 Just -2 -3- 4 Evil 1,-1 Both Just and Evil
GetSchoolRelation|Returns Sect Favor||Int Sect ID|Float
GetFlag|Returns a Flag value||Int Flag ID|Int
RandomInt|Generates a random Int||Int,Int (minimum and maximum)|Int
RandomFloat|Generates a random Float||Float,Float (minimum and maximum)|Float
Kill|杀掉Npc||无|无
SetFlag|Sets a Flag value||Int (Flag ID),Int (Value)|无
AddDamage|Adds damage||String (Injury Type),string (Injury location, bodypart),[float] (Severity),[string] (source)|
AddDamageRandomPart|Adds damage to a random part||Int,string,[float],[string] Component Type ( 1 Bones 2 Organs 3 Skin 4 Meridians 5 Arbitrary), damage name Can also have damage severity and From description after damage name|无
AddDamgeFromCache|Adds a random damage from the damage pool||DamageList,[int],[float],[string] DamageCache,maximum number of damages, Damage Severity, Source Description	 
AddModifier|Adds a modifier||String modifier name Bool Lock current job Default value is false If it’s true, the modifier will be removed after the job(like a breakthrough) is over|无
AddSchoolScore|Adds Sect Reputation||Int Reputation type 1-Base Rep 2-Just Rep 3-Evil Rep Float Value|无
AddSchoolRelation|Adds Sect Favor||Int Sect ID, Float Value|无
AddPracticeResource|Adds a Practice Resource (g_emPracticeResourceType for more information)||g_emPracticeResourceType type,float value|无
AddJoiners|Spawns potential Disciples (used in Join_Base)||Int,int,float,[float],[float],[float],[float],[float],[string] or Number, Quality Level (1-10), if it’s 0, the current base value +2 will be used,Lag Time (days), 5 Base stats, Race (default is human)|无
TriggerStory|Triggers a MapStory||String MapStory name|无
AddMsg|Adds content to the Story panel||String,params Content formatted data The format of the string is used here Example, AddMsg(“{0}{1}”,1,”test”)|无
ShowMsgBox|Shows a popup message box||String (Content), String (Title)|无
DropAwardItem|Obtain rewards, the cultivator will drop them when returning to the Sect||String,count,[stuff],[int],[float], or Name, Quantity, Main Material (if it’s blank and a material is required, it will be random), Artwork number (default is -1, 0 for random, greater than 0 is for -1 and -1 means it’s not Artwork), Quality (0-1)| 
DropAwardItemFromCache|Obtain rewards from a cache, the cultivator will drop them when returning to the Sect||ItemList,[int],[int], or ItemCache, Drop mode, Number of drops(default is 1) For Drop Mode, 0 is for independent drop rate, 1 is for overall drop rate. Only one item is dropped, the drop rate is pulled through (what?)	 
DropRandomItem|Drops a random item||g_emItemLable,[int],[int],[bool], or g_emItemLable (category of the item), Minimum Rank, Maximum Grade, Whether it’s a relic, default is false|无
AddSecret|Adds a Secret||Int (Secret ID)|无
AddSecretFromCache|Adds a Secret from a cache||SecretList|无
UnLockPlace|Unlocks a location||String (Place name)|无
UnLockPlaceFromCache|Unlocks a random location from a cache||PlaceList|Wu
NeckBroken|Breaks through the current breakthrough||无|无
IsTouchNeck|Returns whether the cultivator is at a breakthrough||无|Bool
GetProperty|Returns Property value||String (Property name)|Float
ModifierProperty|Modifies Property, Permanent||String ,[float],[float], or Name, Value added, Percentage added|无
GetSchoolName|Returns Sect Name||Int (Sect ID)|string
DropEsoteric|Drops a manual at the target||String (Manual name)|无
OpenPlaceLinks|Unlocks a sublocation for that area||String (Place Name)|无
IsLearnedMagic|Checks whether a Miracle is learned||String (Miracle name)|Bool
IsLearnedEsoteric|Checks whether a Manual is learned||String (Manual name)|Bool
LearnEsoteric|Learns a manual directly||String (manual name), Bool Add attainment?|无
DropFabao|Drops an artifact||Int,string,[string],[string],[string],[float],[int] , or Artifact type (0 combat, 1 treasure), Item used as material, Main material for item (empty is random), Artifact name (can be empty), Artifact description (can be empty), Quality (random by default), Tier (automatic by default), Reforge count (default is 0)|Example, me:DropFabao(0,"Item_SummerTrousers",nil,"Hot pants","Not the ice bracelet meta")
UnLockGong|Unlocks a law||string (Law name)|无
AddEnemy|Spawns a wave of enemies||int,float,[float],[g_emNpcRichLable],[string] , or Strength added value(initial based on rep), Lag time (days), Attack duration (seconds, optional, default value 100), Wealth (default Normal), Race (default human)| 	无
DropEsotericFromCache|Drops a manual from a cache||ItemList,[int],[int] , or ItemCache, Drop mode, Number of drops( default is 1). For Drop Mode, 0 is for independent drop rate, 1 is for overall drop rate. Only one item is dropped, the drop rate is pulled through (what?)|
UnLockPlaceFromSchool|解锁一个门派的驻地||Int 门派ID|Not used in any MapStories
GetGongName|Returns Law name||String (Law name)|	 
GetRandomEsotericName|Returns a random manual||String (Manual name)|
GetMatchingWithGong|Returns how well a law matches the cultivator||String (Law name)|Float  >=0.5
IsEsotericFull|Checks whether the manuals have reached the maximum number||无|Bool
HasSecret|Checks whether a secret is active||Int (Secret ID)|Bool
UnLockRandomChild|Unlocks a random sub-location||Name (Place name), [int] (Number of unlocks, default 1)
DropSpell|Drops a Talisman||Int (0-2)Paper level, String Talisman name, empty for random, Float  Talisman Quality|
AddTreeExp|Adds Inspiration||Float Value added, bool true for directly without any coefficient|无
AddMemery|Adds a Memory||String Memory name|
ParseNpcStory|Formats a section of NpcStory||String Content, Example:[name] says [other=obj]|String
IsDisciple|Checks whether they are an inner disciple||无|Bool
GetDaoHang|Returns Attainment||无|Int
IsHotNpc|Checks whether they are the current(hot) NPC||无|Bool
UnLockOldGong|Unlocks a previous Law, used with a Decomposed Body||无|无
CheckItemEquptCount|Checks for the amount of equipped items||String , [String] ,[int] , [int] , or Name (name), Tag  (tag name), TagLvMin (tagsmallest level), TagLvMin (taglargest level)|Int (Amount equipped)
GetRoomFengshui|Returns the Feng Shui of the room where the character is|||Int FS value 0-None 1-VA 2-A 3-SA 4-SO 5-O 6-VO
GetTreeExp|Returns Inspiration value|||Float
AddTitle|Adds a title to the cultivator||String,[string],[int], or Title, Description, Level 0-4, default is 4|
AddRandomTitle|Adds a random title to the cultivator||[int -1],[string],[int], or Random Pool -1 any 0 skills 1 realm 2 martial arts, Description, Level 0-4|
GetGoldLevel|Returns Golden Core tier|||Int
GetGoldValue|Returns Golden Core Score|||Float
LearnEsotericCustomize|Learn a customized manual||String: Name prefix ,Int：Element(0:None, 1:Jin, 2:Mu, 3:Shui, 4:Huo, 5:Tu, 6:Chaos), Int: Type（0:Random,1:Artifact Mastery,2:Combat Skills,3:Protection,4:Alchemy,5:Artifact Crafting,6:Practice,7:调心), Bool (true：learn not to follow the path(?),false：add）,Float(X times the highest value, default is 2),Int(Attainment cost, default 1）,Int(Stage requirements 0:None，1:Qi，2:Dan1，3:Dan2，4:God，5：God2), String(Prefix for the name, like “massive”)|The attributes of the five elements of the manual, input by parameters Tier：12
DropOldSchoolFabao|Drops an artifact from the old base|||
HasOldSchoolFabao|Checks if they have the artifact from the old base|||Bool
RandomOldSchoolNpcName|Returns the name of the character of the old school, if none exists it will be random|||String
DropEsotericCustomize|Drops a customized manual||String: Name prefix, Int：Element(0:None, 1:Jin, 2:Mu, 3:Shui, 4:Huo, 5:Tu, 6:Chaos), Int: Type（0:Random,1:Artifact Mastery,2:Combat Skills,3:Protection,4:Alchemy,5:Artifact Crafting,6:Practice,7:调心）,Bool (true：learn not to follow the path(?)false：add）,Float(X times the highest value, default is 2),Int(Attainment cost, default 1）,Int(Stage requirements 0:None，1:Qi，2:Dan1，3:Dan2，4:God，5：God2), String(Prefix for the name, like “massive”)|The attributes of the five elements of the manual, input by parameters Tier：12
GetModifierStack|Returns the number of modifier stacks||String (Modifier name)|Int
CheckMood|Checks if a mood exists||String (Mood name)|Bool
DivideGodSoul|Gets a subspirit||Bool (any related injuries ?),int (number received) |
UnlockGodGuard|Unlocks a Shendao guard||String Guard name , [string]Guards name, don’t use random, [bool=false] whether there is only one of the same type|String Guards name
AddFaith|Increases Faith||Float Value|
GetFaith|Returns Faith value|||Float
GetMoodComplexity|Returns the current mood value|||Float
GetMindStateLevel|Returns the current Mind State level|||Int
GetGodPopulation|Returns the amount of followers|||Int
AddGodPopulation|Adds followers||Int value| 
UnLockGodCityBuilding|Unlocks a divine realm building||String building name|
IsGodPractice|Checks whether the cultivator is a Shendao|||Bool
IsUnLockGodCityBuilding|Checks whether a Divine realm building is unlocked||String building name|Bool
AddPenalty|Increases Condemnation (negative for virtue)||Float value|
UnLockSuperPart|Unlocks a secret body||String Superpart name|Bool
AddQuenchingItem|Adds Essence||String,Int (Name, count)|
AddQuenchingMethod|Adds a quenching method||String method name|Bool
DropSuperPartItem|Drops a Body Profundity||String name|
GetSuperPartLevel|Returns the secret body level||String name|Int -1 no, 0 unfinished
IsEquipSuperPart|Checks whether the secret body is equipped||String name|Bool

## story: Scope

Name|Description|Is a Property|Parameter Description|Return Value
-|-|-|-|-
School|Sect ID where the story happened|1||Int
Place|Name of the place where the story happened|1||String
DamageCache|DamageCache attached to the story|1||DamageList
ItemCache|ItemCache attached to the story|1||ItemList
ItemCache2|ItemCache attached to the story|1||ItemList
ItemCache3|ItemCache attached to the story|1||ItemList
ItemCache4|ItemCache attached to the story|1||ItemList
ItemCache5|ItemCache attached to the story|1||ItemList
PlaceProduce|General item pool attached to the place|1||ItemList
PlaceHighProduce|Rare item pool attached to the place|1||ItemList
PlaceSecrets|Secrets pool attached to the place|1||SecretList
PlaceChildren|Sub-locations attached to the location|1||PlaceList
FinishSecret|Ends the current secret||无|无
GetPlaceSchoolRank|Gets the Sect Alignment attached to the story||无|Int 0 -None 4 -Rank13 3 -Rank12 2 -Rank11 1 -Rank0 -1 -Rank01 -2 -Rank21 -3 -Rank22 -4 -Rank23 0 Unknown 2 3 4 Just -2 -3- 4 Evil 1,-1 Both Just and Evil
RemoveBindItem|Deletes the bound items used for thingstory, which is very special, used to destroy the destruction of ting interaction||无|无
GetBindNpc|Gets the bound NPC, better to judge nil when using it||无|NpcHelpr
GetBindThing|Gets the bound item|||Thing
GetDoingNpc|Gets the NPC doing it|||NpcHelpr
AddYaoShou|Spawns a monster||[String:race，nil for random],[int:strength(1-21)，nil or 0 will generate based on reputation],[int:Stage,(1-12), blank or 0 has no effect,using a higher value adds to the stage ],[float, Realm increase coefficient, blank or -1 will be according to the rules],[string，extra drop]|
AddManyYaoShou|Spawns a wave of monsters||[String:race，nil for random],[int:strength(1-21)，nil or 0 will generate based on reputation],[int:intensity difference value, a larger value will create more or stronger monsters, default value is 0],[float, Realm increase coefficient, blank or -1 will be according to the rules],[string，extra drop, but only for the leader]|

## world: Scope

Name|Description|Is a Property|Parameter Description|Return Value
-|-|-|-|-
GetSchoolName|Returns Sect Name||Int Sect ID|string
GetSchoolRank|Returns Sect alignment||Int Sect ID|Int 0 -None 4 -Rank13 3 -Rank12 2 -Rank11 1 -Rank0 -1 -Rank01 -2 -Rank21 -3 -Rank22 -4 -Rank23 0 Unknown 2 3 4 Just -2 -3- 4 Evil 1,-1 Both Just and Evil
BeginWeather|Starts a Weather||String,[bool] Weather name, whether to overwrite same kind weathers|
DayCount|Current Day|1||
DaySecond|Current Time in seconds|1||
RandomInt|Generates a random Int||Int,int minimum and maximum|Int
RandomFloat|Generates a random Float||Float,Float minimum and maximum|Float
ShowMsgBox|Shows a popup message box||String Content, String Title| 
GetPlaceName|Returns the UI name of the place||String Place name|String
GetPlaceSchool|Returns the Sect of the place||String Place name|Int Sect ID
RandomSchool|Returns a random Sect ID||[int],[int] Sect ID range ，Default is -4,4|Int Sect ID
GetBuildingCount|Returns the number of buildings||String Building name|Int
GetBuildingCountByTag|Returns the number of buildings with a certain tag||String tag|Int
GetItemCount|Returns the number of items||String Item name|Int
GetItemCountByLable|Returns the number of items that have a certain lable||g_emItemLable|Int
RandomGong|Random unlocked Law|||String
CheckRate|Checks the probability, True if it succeeds||Float (0-1)|Bool
UnLockAchievement|Unlocks an achievement||Int Achievement ID|
AddAchievementCount|Increases achievement count||g_emAchievementCountKind,int Type, Quantity|
IsGongUnLocked|Checks whether the law is unlocked||String Law name|Bool
GetWorldFlag|Returns a global Flag value||Int key|Int
SetWorldFlag|Sets a global Flag value||Int,int key，value|无
NeedSave|Saves the game if on Immortal||无|无
SetRandomSeed|Sets a random seed||[Int], Leave blank to set seed, leave blank to change	|
ShowStoryBox|Shows the Story panel||String,string,[luatable],[luafunction] , or Content, Title, [Option Text], [Callback Function]|
GetSelectThing|Returns the currently selected target|||Thing
PlayBGM|Plays a BGM, Does not support mp3||String, [bool=false], Path to music, whether it loops|
PlayAudio|Plays a sound effect, Does not supportmp3||String (Path to effect)|
FlyLineEffect|Flight Line effect||Vector3,Vector3,float,[luafunction], or Start point coordinates, End point coordinates, Duration, [arrival callback]|
FlyLineEffect|Flight Line effect||Int,int,float,[luafunction], or Start Point, End point, Duration, [Arrival callback]|
AddDaNeng|Adds ancient cultivator? Related to ancient cultivator||String(One-time Item cache)|
GetDaNeng|Get ancient cultivator||Luatable(Ancient Cultivator related table)|local tb = {} WorldLua:GetDaNeng(tb) for k,v in pairs(tb) do print(k,v.Name, v.DropKey, v.NpcID, v.Sex) end
CallDaNeng|Summon ancient cultivator||Int(GetDaNeng provides a luatable key)|
GetFlag|Returns the Flag of a Thing||Thing(cs object entity) Int(flag index)|
SetFlag|Sets the Flag of a thing||Thing(cs object entity) Int(flag index) Int(value)|
IsSchoolClosed|Whether the Sect is closed||Int 门派ID|Bool
IsSchoolSubmissionToPlayer|Whether the Sect is surrendered to the player||Int 门派ID|Bool
GetFightMapPlace|Returns the name of the location of the current Fightmap||无|String
GetFightMapHelper|Returns the LuaTable of the FightMap, returns empty if you’re playing the map||无|Luatable
GetFightMapSchoolID|Returns the Sect ID of the Owner of the FighMap,0 if it’s player owned|||Int
DropEsotericCustomize|Drops a customized manual||String: Name prefix,Int：Element(0:None, 1:Jin, 2:Mu, 3:Shui, 4:Huo, 5:Tu, 6:Chaos),Int: Type（0:Random,1:Artifact Mastery,2:Combat Skills,3:Protection,4:Alchemy,5:Artifact Crafting,6:Practice,7:调心）,Bool (true：learn not to follow the path(?) false：add）,Float(X times the highest value, default is 2),Int(Attainment cost, default 1）,Int(Stage requirements0:None，1:Qi，2:Dan1，3:Dan2，4:God，5：God2),String(Prefix for the name, like “massive”)|ItemThing
DropFabao|Drops an artifact||Int,string,[string],[string],[string],[float],[int], or Artifact type (0 combat, 1 treasure),Item used as material,Main material for item (empty is random),Artifact name (can be empty),Artifact description (can be empty),Quality (random by default),Tier (automatic by default),Reforge count (default is 0)|
UnlockBuilding|Unlocks a building||String: Building name|
IsBuildingUnlocked|Checks whether a building is unlocked||String: Building name|Bool
GetNow()|Returns current time zone time|||
GetUtcNow()|Returns current UTC time|||
UnLockJianghuClue|Unlocks a Secrets Clue||Int ID|
UnLockJianghuSecret|Unlocks a Secrets Secret||Int ID|
UnLockJianghuNpc|Unlocks a Secrets NPC||String npcname|
UnlockRandomGong|Unlocks a random Law||Int level (1.Core Shaping 2.Golden Core,3.Primordial Spirit,4.Ascension, Others：Random, according to power level)|
UnLockIllHand_MapStory|Unlocks a an Adventure entry in the codec, with the ID||Int MapStory ID|
UnLockWorld|Unlocks an RPG map||String: RPG mapname|

## Spirit Root related interface
First, retrieve the Spirit Root lua object according to story.target, and get the data through the interface call below. (this section might make sense only if you’re working on Spirit Roots)
Example

Name|Description|Is a Property|Parameter Description|Return Value
-|-|-|-|-
GetFlag|Same as above	 	 	 
SetFlag|Same as above	 	 	 
ShowMsgBox|Same as above	 	 	 
RandomInt|Same as above	 	 	 
RandomFloat|Same as above	 	 	 
GetSchoolName|Same as above	 	 	 
UnLockOldGong|Same as above	 	 	 
UnLockGong|Same as above	 	 	 
AddJoiners|Same as above	 	 	 
AddEnemy|Same as above	 	 	 
HasSecret|Same as above	 	 	 
GetSchoolScore|Same as above	 	 	 
GetSchoolRank|Same as above	 	 	 
GetSchoolRelation|Same as above	 	 	 
AddSecret|Same as above	 	 	 
AddSecretFromCache|Same as above	 	 	 
UnLockPlace|Same as above	 	 	 
OpenPlaceLinks|Same as above	 	 	 
UnLockRandomChild|Same as above	 	 	 
UnLockPlaceFromCache|Same as above	 	 	 
UnLockPlaceFromSchool|Same as above	 	 	 
GetRoomFengshui|Same as above	 	 	 
DropAwardItem|Same as above	 	 	 
DropRandomItem|Same as above	 	 	 
DropEsoteric|Same as above	 	 	 
DropFabao|Same as above	 	 	 
DropSpell|Same as above	 	 	 
DropAwardItemFromCache|Same as above	 	 	 
DropEsotericFromCache|Same as above	 	 	 
plant|Plant object|1||
GetYunYangTarget|获取上次蕴养对象|||PlantYunYangTargetInfo(The example below has more details)
AddLingSha|Adds to the current Blessing value||Single(Value to be added)|
GetLing|Returns Qi value|||Single
AddLing|Add Qi||Single(Value to be added)|
GetName|Returns the type of the plant|||String
GetJiaoGanNpcList|Returns a list of Sympathetic NPCs||LuaTable(The list exists in this table)|
GetLingSha|Get the current Blessing value|||Single
GetGrowProgress|Returns Growth Progress|||Int32(0~100)
GetHarvestProgress|Returns Harvest Progress|||Int32(0~100)
AddMsg|Same as above	 	 	 
TriggerStory|Same as above	 	 	 
AddSchoolScore|Same as above	 	 	 
AddYaoShou|Same as above||Same as above	 
AddManyYaoShou|Same as above||Same as above	 

```lua
PlantYunYangTargetInfo的内容
local target = story.target:GetYunYangTarget()
local 上次蕴养的表现名字 = target.Name  -- string
local 上次蕴养的逻辑种族 = target.DefName -- string
local 上次蕴养的品阶 = target.Rate -- int， 就是rate对应的值
local 上次蕴养的五行属性 = target.ElementKind --  Int （0无 1金木水火土  6混元）
local 上次蕴养物的灵气（本身灵气+丹药灵气） = target.LingV -- float
```
