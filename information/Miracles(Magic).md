# Miracles (Magic)

This document is about Miracles, internally called Magic. Miracles are used out of combat, unlike Spells.

Magics are defined under Settings\Practice\Magic, in an xml file. An example is below:

```xml
<Magics><List>
	<Magic Name="SYS_LOST">
		<DisplayName>模组丢失</DisplayName>
		<Desc>失落之物，没有人认识这个。\n（模组丢失）。</Desc>
		<Icon>res/Sprs/ui/icon_del</Icon>
		<CostLing>9999999999999</CostLing>
	    <IllustratedHandLabel>Dele</IllustratedHandLabel>
	</Magic>
</List></Magics>
```

Due to the possible complexity of Magics and the difficulties in categorizing everything, this document currently contains only the list of possible parameters.

Each `<Magic>` can consist of the following properties:

- Name - Internal name of the Magic.
- Parent -  Used to inherit properties of another Magic, not utilized for existing Magics.
- Type -  Either None or Class, defaults to None. Class Type is used with the ClassName property.
- DisplayName - Name of the Magic shown in game.
- Desc - Description of the Magic shown in game.
- Icon - Relative path to the icon of the Magic.
- Ani - Caster animation used for the Magic.
- CostLing - A static Qi Cost for the Magic.
- LuaCostLing - A dynamic Qi Cost for the Magic, utilizing lua.
- CostMaxLing - A static Max Qi Cost for the Magic.
- LuaCostMaxLing - A dynamic Max Qi Cost for the Magic, utilizing lua.
- CostAge - A static Lifespan cost for the Magic.
- LuaCostAge - A dynamic Lifespan cost for the Magic, utilizing lua.
- CostGong - A static Cultivation XP cost for the Magic.
- CostFaith - A static Belief cost for the Magic (found with Shendao Miracles).
- LuaCostFaith - A dynamic Belief cost for the Magic (found with Shendao Miracles), utilizing lua.
- LuaGetCost - A dynamic cost for the Magic, utilizing lua. Currently used with Spirit Pet Miracles, related to growth.
- ItemCost - A static Item cost for the Magic.
- MinDis - A minimal distance, used for Spirit Pet Miracles related to terrain changes.
- Param1 - First Parameter, a float.
- Param2 - Second Parameter, a float.
- Param3 - Third Parameter, a float.
- Param4 - Fourth Parameter, a float.
- Param5 - Fifth Parameter, a float.
- sParam1 - First Parameter, a string.
- sParam2 - Second Parameter, a string.
- sParam3 - Third Parameter, a string.
- sParam4 - Fourth Parameter, a string.
- sParam5 - Fifth Parameter, a string.
- CheckTag - Checks whether the target has a required Tag or not.
- GodPower - Can be used to add Divinity, not utilized with existing Magics.
- Penalty - Used to add Penalty for using the Magic. A positive value for increasing condemnation, a negative value decreasing it (or adding virtue).
- ScoreBase - Amount of Base Reputation gained for using the Magic. A negative value used for decreasing Reputation. Existing Miracles utilize it with the following two Magic, by reducing ScoreBase with the amount increased in ScoreGood/ScoreBad 
- ScoreGood - Amount of Good/Just Reputation gained for using the Magic.
- ScoreBad - Amount of Bad/Evil Reputation gained for using the Magic.
- TargetMood - Mood added to the Target of the Magic.
- CastFavor -  A String, adding a Favor to the target after casting the Magic. 
- ClassName - The Class of the Magic. 
- TargetAni - Animation used for the target of the Magic.
- TargetDesc - Description used when selecting the target.
- MaxArea - Largest amount of Area possible to select with the Magic.
- Kind - The Kind of Magic, four possible values, None, Good, Bad, or VeryBad. Good Kind Magics add a positive mood for the target and for anyone witnessing, while Bad and VeryBad add a negative mood for the target and anyone witnessing.
- IllustratedHandLabel -  To be Specified, either the Codex or tracking for Achievements.
- CMD - The Command for the Magic, used in place of ClassName.
- SelectType - Target Selection, used together with the CMD.
- CheckFlag - Used with Target Selection, an example use case can be found in the Remolding Miracles.
- EnableFlag - Used to Enable a Flag with the Magic. Currently used with only AbsorbGong_9 and its derivatives.
- SelectMode - A selection mode, can be None, Single, Line, Straight, Rect, Ellipse, or Path.
- SelectTarget - Additional conditions for Target Selection. A commonly used value is Npc, together with SelectMode.Single.
- TexPath - Not utilized.
- ShowInPAttacker - A value of 1 is used to enable Magic in other Maps. Currently used for Seal Contract and Act Playful.
- UnLockThink - Used to enlighten animals. Can also be used to grant thought shards.