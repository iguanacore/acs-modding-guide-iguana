# Manuals (Esoterica)

This document is about manuals, or Esoterica.

Manuals are used with Xiandao cultivators, they either affect the cultivator, or unlock something.
Manuals are located under Settings\Esoterica

The manuals are defined under `<Esotericas>`. Here’s an example of the LOST manual:
```xml
<Esoterica Name="Esoterica_SYS_LOST">
        <DisplayName>模组丢失</DisplayName>
        <StarLevel>0</StarLevel>
        <Difficulty>0</Difficulty>
        <Desc>失落之物，没有人认识这个。\n（模组丢失）</Desc>
        <Type>None</Type>
        <GLevel>None</GLevel>
        <Element>None</Element>
        <EffectDesc>无</EffectDesc>
</Esoterica>
```
- Name - Name of the manual.
- `<DisplayName>` - Ingame name displayed, can be changed with translations.
- `<StarLevel>` - Related to Difficulty. Below 4, it’s 0. Between 4 and 7, it’s 1. Over 7, it’s 2.
- `<Difficulty>` - Related to the Attainment of the manual. Related to the Inspiration cost for learning.
- `<Desc>` - The description for the manual, shown in the upper section of the manual.
- `<Type>` - Category for the manual, as seen under the Manual Pavilion. Possible values are None (Misc), Fabao (Artifact Mastery), Skill (Combat skills), Barrier (Protection), Dan (Alchemy), Refining (Artifact Crafting), Gong (Practice), Art (Unused)
- `<Glevel>` - Minimum state of the cultivator. Qi (Qi Shaping) < Dan1 (Core Shaping) < Dan2 (Golden Core) < God (Primordial Spirit) < God2 (Demi-God). None is the same as Qi.
- `<Element>` - Element of the manual, for elemental relations. The possible values are None, Jin (Metal), Mu (Wood), Shui (Water), Huo (Fire), Tu (Earth).
- `<EffectDesc>` - The description of the effect, shown at the bottom of the manual.

That is the most basic manual, without any effects. Other commonly used parameters:

- `<Exp>` - Used to set the Inspiration cost directly, but it’s rarely used.
- `<Hide>` - Used to hide the manual from the Manual Pavilion.
- `<Mutex>` - Used to set mutually exclusive manuals.
- `<PreNeed>` - Used to set a prerequisite manual.
- `<ProduceModes>` - Used to add acquisition methods for the manual, commonly seen with Realms Palace Content Editor creations

Manuals can have the following effects:

- Unlocking combat skills for the cultivator
- Unlocking Alchemy recipes for the cultivator
- Unlocking Legacy Artifact recipes for the cultivator
- Unlocking Talismans for the cultivator
- Unlocking locations for that save
- Unlocking secrets for that save
- Unlocking Formation nodes for that save
- Unlocking Formation diagrams for that save
- Setting a Flag (not used in current ingame manuals)
- Adding a modifier for the cultivator
- Unlocking a miracle for the cultivator
- Unlocking buildings for your sect
- Adding a subspirit to the cultivator

## Combat Skill manuals
Used in combat, an example with Innate Qi:
```xml
<Esoterica Name="FightSkillEsoterica_1">
    <DisplayName>先天罡气</DisplayName>
    <Icon>res/Sprs/ui/icon_shufa</Icon>
    <StarLevel>0</StarLevel>
    <Difficulty>3</Difficulty>
    <Desc>修行者的入门法术，将真气凝聚于掌心向目标发出即可。</Desc>
    <GLevel>Qi</GLevel>
    <Element>None</Element>
    <Type>Skill</Type>
    <EffectDesc>[size=10][color=#D06508]习得秘术：先天罡气[/color][/size]</EffectDesc>
    <Skills>
        <li>DamageSkill_1</li>
    </Skills>
</Esoterica>
```
`<Skills>` part is where the skill is added. The skills themselves are listed under Settings\Fight\FightSkillTemplate

## Alchemy Recipe manuals
Used to unlock Alchemy recipes for that cultivator. An example with Eureka Pill:
```xml
<Esoterica Name="God2_Dan">
    <DisplayName>天道神丹</DisplayName>
    <StarLevel>2</StarLevel>
    <Difficulty>10</Difficulty>
    <GLevel>God2</GLevel>
    <Desc>既度天劫，洞彻天道。如炼丹造诣登峰造极，即可领悟窃天道炼制神丹之术。</Desc>
    <Element>None</Element>
    <Type>Dan</Type>
    <EffectDesc>[size=10][color=#D06508]习得 丹方：\n天道神丹[/color][/size]</EffectDesc>
    <Dans>
        <li>Dan_TreeEXP</li>
    </Dans>
</Esoterica>
```
`<Dans>` part is where the recipe is added. The recipes are defined under `<DanFormulas>` in Settings\Practice\DanFormula\Dan.xml

## Legacy Artifact manuals
Used to unlock Legacy Artifact recipes for that cultivator. An example with Sword of Dubhe:
```xml
<Esoterica Name="Gong8_LvUpEsoterica_12">
    <DisplayName>秘宝：天枢剑</DisplayName>
    <Hide>2</Hide>
    <StarLevel>1</StarLevel>
    <Difficulty>4</Difficulty>
    <Desc>记录秘宝：天枢剑的炼制方法。</Desc>
    <Element>None</Element>
    <Type>None</Type>
    <EffectDesc>[size=10][color=#D06508]习得 秘宝：\n天枢剑[/color][/size]</EffectDesc>
    <Fabaos>
        <li>MiBaoFormula_TianShu</li>
    </Fabaos>
</Esoterica>
```
`<Fabaos>` part is where the recipe is added. The recipes are defined under `<FabaoFormulas>` in Settings\Practice\FabaoFormula\Fabao.xml

## Talisman manuals
Used to unlock Talismans for that cultivator. An example with Prayer Talisman:
```xml
<Esoterica Name="Esoterica_LunHui5">
    <DisplayName>申申符</DisplayName>
    <Desc>让人感到平安快乐的符咒。</Desc>
    <Hide>0</Hide>
    <Element>None</Element>
    <Type>None</Type>
    <EffectDesc>解锁 符图：\n申申符</EffectDesc>
    <Spells>
        <li>Spell_LunHui_ShenShen</li>
    </Spells>
</Esoterica>
```
`<Spells>` part is where the talisman is added. The talismans are defined under Settings\Practice\Spell.

## Location manuals
Used to unlock locations on the world map. An example with Records of the Immortals: Vol 2:
```xml
<Esoterica Name="QunXianLu_2">
    <DisplayName>群仙录：卷二</DisplayName>
    <Desc>记载前古诸位仙人事迹的书册，已经失踪千年。本册记录的乃是青莲仙人年轻时游历的事迹。\n传闻青莲仙人乃是天上太白星转生，天生乃庚金之体。成道之前曾于南海隐居数年，而后回归蜀山，于飞雷洞飞升。其最终隐居之所数千年来都无人寻到。</Desc>
    <Hide>1</Hide>
    <Element>None</Element>
    <Type>None</Type>
    <Difficulty>0</Difficulty>
    <EffectDesc>获得地点信息：\n秘境-南海青莲山</EffectDesc>
    <Places>
        <li>Place_QingLianShan</li>
    </Places>
</Esoterica>
```
`<Places>` part is where the location is added. The locations are defined under Settings\World\Places.

## Secret manuals
Used to unlock Secrets on the world map. An example with Records of the Immortals: Vol 3:
```xml
<Esoterica Name="QunXianLu_3">
    <DisplayName>群仙录：卷三</DisplayName>
    <Desc>记载前古诸位仙人事迹的书册。本册记录的乃是天极老祖建立极天宫后游历人间的趣事。\n传闻天极老祖于北疆造化万里极天宫仙境，留下极天宫道统后便化形游历人间，并暗自庇护极天宫游历弟子，留下许多传说。后天极老祖销声匿迹，再不见仙踪。</Desc>
    <Hide>1</Hide>
    <Element>None</Element>
    <Type>None</Type>
    <Difficulty>0</Difficulty>
    <EffectDesc>获得秘闻：\n古天极符</EffectDesc>
    <Secrets>
        <li>50</li>
    </Secrets>
</Esoterica>
```
`<Secrets>` part is where the secret is added. The secrets are defined under Settings\Secrets, the ID is used for the manual.

## Formation node and diagram manuals
Also explained in the [Formations resource](Formations(Zhen).md)

### Formation nodes
Formation nodes can be added under a `<ZhenNodes>` section.

Each entry (the part within a li) is a single node.
An example of a manual containing a single entry, from ACS_M_EX_02
```xml
    <Esoterica Name="ACS_M_EX_EsotericaZhenFa_2">
		<DisplayName>Formations: Example 02</DisplayName>
		<StarLevel>1</StarLevel>
		<Difficulty>1</Difficulty>
		<Desc>This is the description</Desc>
		<EffectDesc>This is the effect, formated.\nUnlocks Node: \nPaired Sword</EffectDesc>
		<GLevel>Qi</GLevel>
		<Element>None</Element>
		<ZhenNodes>
			<li>ZhenNode_Lv1_Jian_2_1_ACS_M_EX</li>
		</ZhenNodes>
	</Esoterica>
```

### Formation diagrams
Formation diagrams can be added under a `<ZhenShapes>` section.

Each entry (the part within a li) is a single diagram. Each entry consists of three paramters, the Name, ShapeInfo and Descript.
- Name - Name of the diagram, not limited to 7 characters like the diagrams you creat ingame.
- ShapeInfo - The string of the diagram, more detail below
- Descript - The description of the diagram
An example of a manual containing a single entry, from ACS_M_EX_05
```xml
    <Esoterica Name="ACS_M_EX_EsotericaZhenFa_5">
		<DisplayName>Formations: Example 05</DisplayName>
		<StarLevel>1</StarLevel>
		<Difficulty>1</Difficulty>
		<Desc>This is the description</Desc>
		<EffectDesc>This is the effect, formated.\nUnlocks Formation Diagram: \nConcentrated Sword Aura Formation</EffectDesc>
		<GLevel>Qi</GLevel>
		<Element>None</Element>
		<ZhenShapes>
            <li Name="Concentrated Sword Aura Formation">
            <ShapeInfo>10|9|0|ZhenMainNode_Lv1_3_13|10|10|2|ZhenNode_Lv1_2_7|11|10|3|ZhenNode_Lv1_3_13|11|9|5|ZhenNode_Lv1_2_7</ShapeInfo>
            <Descript>A simple formation, using Concentrated Sword Aura as a pillar.</Descript>
            </li>
        </ZhenShapes>
	</Esoterica>
```

## Manuals adding modifiers
The most common type, adding a modifier to your cultivator. An example with Wild Punch:
```xml
<Esoterica Name="Esoterica_LunHui1">
    <DisplayName>野球拳</DisplayName>
    <StarLevel>2</StarLevel>
    <Difficulty>8</Difficulty>
    <Desc>来自现代的神秘秘籍，有改换体质的妙用。</Desc>
    <Type>None</Type>
    <GLevel>Qi</GLevel>
    <Element>None</Element>
    <EffectDesc>提高神识1成\n提高悟性1成\n提高机缘1成</EffectDesc>
    <Modifier>Esoterica_LunHui1</Modifier>  
</Esoterica>
```
`<Modifier>` part is where the modifier is added. Modifiers are defined under Settings\Modifiers.

## Manuals unlocking miracles
Somewhat less common type, unlocking a miracle for the cultivator. An example with Incredible Punch:
```xml
<Esoterica Name="Esoterica_LunHui3">
    <DisplayName>爆发之力</DisplayName>
    <StarLevel>2</StarLevel>
    <Difficulty>8</Difficulty>
    <Desc>独孤星独门绝技，可以突然爆发出强大的力量。</Desc>
    <Type>None</Type>
    <GLevel>Qi</GLevel>
    <Element>None</Element>
    <EffectDesc>[size=10][color=#D06508]习得神通：爆发之力\n独孤星独门绝技，可以突然爆发出强大的力量。[/color][/size]</EffectDesc>
    <Magics>
        <li>AbsorbGong_9_3</li>
    </Magics>
</Esoterica>
```
`<Magics>` is the part where the miracle is added. Miracles are defined under Settings\Practice\Magic

## Manuals unlocking buildings
Rarely used, for unlocking buildings. There are two ingame, an example with the Illustrated Book of Coming Spring:
```xml
<Esoterica Name="SpellEsoterica_6">
    <DisplayName>迎春图册</DisplayName>
    <Desc>来自异界的神秘书册，记载有许多来自一个伟大国度的风俗文化。</Desc>
    <Hide>0</Hide>
    <Element>None</Element>
    <Type>None</Type>
    <Difficulty>0</Difficulty>
    <EffectDesc>解锁 符图：\n万福图\n万禄图\n万寿图\n\n解锁 建筑：\n灯笼-万化安\n灯笼-四海同\n屋顶-迎春\n屋顶-纳福\n烟花-龙歌</EffectDesc>
    <Spells>
        <li>Spell_Fu</li>
        <li>Spell_Lu</li>
        <li>Spell_Shou</li>
    </Spells>
    <Buildings>
        <li>Lantern6</li>
        <li>Lantern5</li>
        <li>WoodRoof_SpringFestival</li>
        <li>StoneRoof_SpringFestival</li>
        <li>Firecracker</li>
    </Buildings>
</Esoterica>
```
`<Buildings>` part is where the buildings are unlocked. Buildings are defined under Settings\ThingDef\Building.

However, the unlockable buildings (and the category assignment) are defined in Settings\Ui\MainList.

## Manuals adding subspirits
Usually found from Ancient cultivators, adding subspirits. An example with the Qi of Triple Purity:
```xml
<Esoterica Name="Other_Esoterica_FenShen1">
        <DisplayName>一气化三清</DisplayName>
        <StarLevel>2</StarLevel>
        <Difficulty>15</Difficulty>
        <Desc>上古道门炼神秘法，早已失传。修炼此术可使元神分化，产生三条分神。</Desc>
        <GLevel>God</GLevel>
        <Element>None</Element>
        <Type>None</Type>
        <EffectDesc>[size=10][color=#D06508]增加三条元神分神[/color][/size]</EffectDesc>
        <GodSoulCount>3</GodSoulCount>
</Esoterica>
```
`<GodSoulCount>` is the amount of subspirits added.
