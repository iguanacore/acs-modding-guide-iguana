# Modifiers

Modifiers are a way of modifying something. The existing modifiers are located under `Settings\Modifiers`.

A `<Modifier>` is found within the `<ModifierDefs>`, here's an example from the example mod:

```xml
<ModifierDefs><List>
	<Modifier Name="ModTest_Modifier" Type="Normal">
		<DisplayName>演示Modifier</DisplayName>
		<Desc>演示Modifier</Desc>
		<MaxStack>0</MaxStack>
		<Duration>0</Duration>
		<Display>1</Display>
		<Sync>1</Sync><!--跨场景时是否同步-->
		<Properties>
			<li Name="MoveSpeed" AddV="5"/>
		</Properties>
	</Modifier> 
</List></ModifierDefs>
```

That is the most basic example of a modifier, something influencing a property. For Modifiers, the common properties are:

 - Name - Internal identifier, unique
 - Type - Always Normal
 - DisplayName - Name displayed when hovering over it.
 - Desc - Description displayed when hovering over it
 - MaxStack - The stack limit, how many times the modifier can be added.
 - Duration - The duration of the modifier, anything above zero makes the modifier temporary.
 - Display - Whether the modifier is shown or not. Temporary modifiers are usually shown.

Just like other objects, Modifers can have inheritance. An example can be seen with the Spirit Contract modifiers.
```xml
<Modifier Name="Modifier_Horse_Fei_0" Type="Normal" Parent="Modifier_Horse_All_0">
    <DisplayName>蜚</DisplayName>
    <UnLockMagic>
        <li>PrayForRain_FeiHorse</li>
    </UnLockMagic>
</Modifier> 
```
The list below is an example of the different modifiers already ingame. If something isn't included, contact the author.

## Modifier influencing a property

The most common example.
```xml
<Modifier Name="Character_Initialization" Type="Normal">   <!--角色初始化-->
    <DisplayName>Character_Initialization</DisplayName>
    <MaxStack>0</MaxStack>
    <Duration>-1</Duration>
    <Display>0</Display>
    <Properties>
        <li Name="NpcLingMaxValue" AddP="1"/>   <!--初始灵气补正-->
    </Properties>
</Modifier>
```

For the Properties, each entry is a single property. Consists of the name and type of change.
- Name - The internal name of the property
- Type of change

There are four types, AddP, AddV, BAddP, and BAddV.

- AddP - Percentage Increase
- AddV - Value Increase
- BAddP - Base Percentage Increase
- BAddV - Base Value Increase

For Percentages, remember that 1 is equal to 100%.

## Modifier incluencing a skill

A less common example, a modifier changing Skill levels. This is from Supreme Form - Tier III:
```xml
<Modifier Name="Gong9_LvUpEsoterica_11" Type="Normal">
    <DisplayName>Gong9_LvUpEsoterica_11</DisplayName>
    <MaxStack>0</MaxStack>
    <Duration>-1</Duration>
    <Display>0</Display>
    <Skills>
        <li Name="Fight" LevelOver="5"/>
    </Skills>
</Modifier>
```

For the Skills, each entry is a single skill. Consists of five possible properties.

- Name - Skill Name
- Level - The amount of levels changed (negative for decreasing skill levels)
- LevelOver - The amount of levels the Skill Cap is changed by.
- Exp - Not found in current examples.
- Type - Not found in current examples.

## Modifier changing the model of the NPC

A modifier can change the model used for the NPC. This is the modifier added to the Demon Emperor.
```xml
<Modifier Name="System_CGModifier" Type="Normal">
    <DisplayName>特殊变身</DisplayName>
    <MaxStack>0</MaxStack>
    <NpcModPath>Mod/Npc/Hero1/Base</NpcModPath>
    <Duration>-1</Duration>
    <Display>0</Display>
    <Sync>1</Sync><!--跨场景时是否同步-->
</Modifier>
```

The NpcModPath is the location for the model used.

## Modifier adding a Flag for the target

A modifier can add a SpecialFlag for the target. This is the modifier found for the Vessels acquired from the Agency Wonder.
```xml
<Modifier Name="SysInfiPuppet" Type="Normal"><!--傀儡附带modifier-->
    <DisplayName>六道傀儡</DisplayName>
    <Desc>这具傀儡为特殊材料所制，不会在日常工作中磨损。但被攻击仍然会损坏。</Desc>
    <MaxStack>1</MaxStack>
    <Duration>-1</Duration>
    <Display>1</Display>
    <SpecialFlags>
        <li>FLAG_INFHP_PUPPET</li>
    </SpecialFlags>
<!--<Damages>
        <li Part="TheWholeBody" Damage="Puppet_Abrasion" Value="0.001"/>
    </Damages>-->
</Modifier> 
```

The SpecialFlags can consist of multiple entries, each being a single flag.

The commented Damages part has been included as it also exists in the original files.

## Modifier adding damages to the target

A modifier can cause injures, or add damages. This is the modifier that adds Exhausted damage.
```xml
<Modifier Name="SysTooTired" Type="Normal"><!--开局晕倒的buff-->
    <DisplayName>劳累过度</DisplayName>
    <Desc></Desc>
    <MaxStack>1</MaxStack>
    <Duration>-1</Duration>
    <Display>1</Display>
    <Damages>
        <li Part="TheWholeBody" Damage="SysTooTired"/>
    </Damages>
</Modifier>
```

The Damages can consist of multiple entry, each entry consists of:

- Part - The part of the body the damage is applied to
- Damage - The damage being applied
- Value - The strength of the damage, optional value

## Modifier having no direct effect

Modifiers can also be used without any effects. These modifiers are used for other functions, and are similar to just setting a temporary flag. This is the modifier that is used with consuming medicines for Spirit Pets.
```xml
<Modifier Name="Modifier_Dan_ColdDown" Type="Normal"><!---->
    <DisplayName>药物吸收</DisplayName>
    <Desc>需要一定时间完全吸收各类药物拥有的营养，在此期间无法再通过食用药物获得营养。</Desc>
    <MaxStack>1</MaxStack>
    <Display>1</Display>
    <Duration>1200</Duration>
</Modifier>
```

## Modifier setting a World Flag

Modifiers can set a World Flag. This is the modifier that is applied with Universal Calculation.
```xml
<Modifier Name="Modifier_Sys_Magic_Prophesy" Type="Normal">
    <DisplayName>周天神算</DisplayName>
    <Desc>当有事件发生前， 会预先给出提示。</Desc>
    <MaxStack>1</MaxStack>
    <Duration>-1</Duration>
    <Display>1</Display>
    <WorldFlags>
        <li>Magic_Prophesy</li>
    </WorldFlags>
</Modifier>
```

Each WorldFlags entry is a separate WorldFlag.

## Modifier incluencing the base stats of a NPC

Modifiers can change the BaseFive stats of an NPC. As seen with the modifier for the Sacred Nimbus Plate tool.
```xml
<Modifier Name="SysTool_Fun6" Type="Normal">
		<DisplayName>玄天上帝圣牌</DisplayName>
		<Desc></Desc>
		<MaxStack>1</MaxStack>
		<Duration>-1</Duration>
		<Display>0</Display>
		<Sync>1</Sync>
		<BaseFive>0,0,0,0,0.5</BaseFive>
		<Properties>
			<li Name="MindStateBaseValue" AddV="6"/>
		</Properties>
</Modifier> 
```
BaseFive is a string, made up of five values, seperated by commas. The value is a percentage, a 1 for 10% Increase.

The order is PER, CON, CHA, INT, LUK.

## Modifier adding a mood to the NPC

Modifiers can add a Mood to the NPC. For example, the modifier after being healed by a Spirit Pet.
```xml
<Modifier Name="Modifier_LingChong_Heal" Type="Normal">
		<DisplayName>陪伴</DisplayName>
		<Desc>在灵宠的陪伴下，伤势恢复地更快了。</Desc>
		<MaxStack>1</MaxStack>
		<Duration>200</Duration>
		<Display>1</Display>
		<Properties>
		    <li Name="RecoveryPower" AddP="3"/>
			<li Name="MagicDamageRecoveryPowerAddV" AddP="3"/>
		</Properties>
		<Moods>
			<li>PetHeal</li>
		</Moods>
	</Modifier> 
```
Each Moods entry is a single Mood being added.

## Modifiers banning jobs

Modifier can ban certain jobs for NPCs. More commonly used with features, also seen with Slacked in Work.
```xml
<Modifier Name="NegativeTime" Type="Normal"><!--消极怠工时获得的不满意-->
    <DisplayName>怠工</DisplayName>
    <Desc>这种生活真是一团糟，无心干活。[color=#D06508]（情绪45以上消失）[/color]</Desc>
    <MaxStack>1</MaxStack>
    <Duration>600</Duration>
    <Display>1</Display>
    <SpecialFlags>
        <li>FLAG_NEGATIVETIME</li>
        <li>FLAG_NEGATIVETIME</li>
        <li>FLAG_NEGATIVETIME</li>
    </SpecialFlags>
    <BanJobs>
        <li>Cooking</li>
        <li>Hunting</li>
        <li>Build</li>
        <li>Plant</li>
        <li>Mine</li>
        <li>Cutoff</li>
        <li>Smithing</li>
        <li>Sew</li>
        <li>Handwork</li>
        <li>Carry</li>
        <li>Clean</li>
    </BanJobs>
    <EndModifier>NegativeTime_Hearten</EndModifier>
	</Modifier>
```

Each BanJobs entry is a single Job that is banned.

## Modifiers adding a modifier when expiring

Modifiers can add another modifier when they get removed (duration ending). The above example adds another modifier when it expires.

EndModifier contains the Modifier added.

## Modifiers adding modifiers

Modifiers can add another Modifier. An example with the Fortune Dew elixir.
```xml
<Modifier Name="Modifier_Item_ZaoHuaYuLu" Type="Normal">
    <DisplayName>造化玉露</DisplayName>
    <Desc>服用造化玉露，元神进入寂灭。</Desc>
    <MaxStack>1</MaxStack>
    <Duration>48600</Duration>
    <Display>1</Display>
    <Sync>1</Sync>
    <Modifiers>
        <li>Modifier_Item_ZaoHuaYuLu1</li>
    </Modifiers>
    <Damages>
        <li Part="Brain" Damage="ZaoHuaYuLu_YuanShenJiMie" Value="0.8"/>
    </Damages>
</Modifier> 
```
Each Modifiers entry is a single Modifier, multiple can be added.

## Modifiers with custom scripts

Modifiers can have custom scripts attached to them. These are Lua scripts, an example with the Countercharge (Pet) skill.
```xml
<Modifier Name="LingShou_fanshi" Type="Normal"><!--龙吸BUFF 挂在对象身上的-->
    <DisplayName>灵宠反噬</DisplayName>
    <Desc>一段时间之后将反噬其法宝，法宝灵气削减一半，火属性的法宝效果翻倍，土属性法宝效果减半。</Desc>
    <MaxStack>1</MaxStack>
    <Duration>10</Duration>
    <Display>1</Display>
    <LuaClassName>modifier_lingshou_fansi</LuaClassName>
    <EffectBind>
        <li Path="Effect/A/Prefabs/Aura/SpinningAura/SpinningWater" />
    </EffectBind>
</Modifier> 
```
LuaClassName is the name used in the related script.

Special classes can also be used, in those cases, ClassName is used instead of LuaClassName. A common example is the Feng Shui relics.
```xml
<Modifier Name="SP_FSZhenWu_14" Type="New">
    <DisplayName>兜率葫芦</DisplayName>
    <Desc></Desc>
    <ClassName>Modifier_Zhenwu</ClassName>
    <MaxStack>1</MaxStack>
    <Duration>-1</Duration>
    <Display>0</Display>
    <Properties>
        <li Name="DanMake_SpeedAddV" AddV="0.25"/>
        <li Name="DanMake_SuccessRateAddV" AddV="0.25"/>
        <li Name="DanMake_YieldAddP" AddV="0.25"/>
    </Properties>
</Modifier> 
```
## Modifiers adding an effect to the target

Modifiers can add an effect to the target. This is a visual effect, just like the name suggests. For example, the weak links in formations:
```xml
<Modifier Name="Zhen_RevealEffect" Type="Normal">
    <DisplayName>暴露阵眼</DisplayName>
    <Desc>这个阵眼已暴露，攻击他可以造成更多伤害，也可以通过变阵来掩盖。</Desc>  
    <MaxStack>1</MaxStack>
    <Duration>-1</Duration>
    <Display>1</Display>
    <EffectBind>			
        <li Path="Effect/gsq/Prefab/ZhenFa03" Bip="Dummy001"/>
    </EffectBind>
</Modifier>
```
Each EffectBind contains a path to the Effect. It can also contain a Bip it's attached to. If no Bip is set, it's added to the center of the target.

## Modifiers changing the material data

Modifiers can change the Material Datas. An example with the Sneaking related modifier.
```xml
<Modifier Name="SysConcealmentModifier" Type="Normal"><!--隐匿-->
    <DisplayName>隐匿</DisplayName>
    <Desc>隐匿气息，降低被发现的概率。\n离开隐匿需要五秒。</Desc>
    <MaxStack>1</MaxStack>
    <Duration>-1</Duration>
    <Display>1</Display>
    <ClassName>Modifier_Concealment</ClassName>
    <Properties>
        <li Name="MoveSpeed" AddP="-0.1"/>
    </Properties>
    <SpecialFlags>
        <li>FLAG_CONCEALMENT</li>
    </SpecialFlags>
    <MaterialDatas>
        <li Name="_Dark" Value="0"/>
    </MaterialDatas>
    <EffectBind>			
        <li Path="Effect/System/Concealment"/>
    </EffectBind>
</Modifier> 
```
Each MaterialDatas entry consists of the Material name, and the value it's being set to.

## Modifiers adding a modifier for all NPCs

Modifiers can also introduce another Modifier for all NPCs. Used like a global buff, as seen with Heart of Prayer.
```xml
<Modifier Name="SysTool_LunHui_QiYuan1" Type="Normal">
    <DisplayName>祈愿之心</DisplayName>
    <Desc>持有祈愿之心，周围的人感到平安喜乐。</Desc>
    <MaxStack>1</MaxStack>
    <Duration>-1</Duration>
    <Display>0</Display>
    <Sync>1</Sync>
    <GlobleModifiers>
        <li>SysTool_LunHui_QiYuan2</li>
    </GlobleModifiers>
</Modifier>
```
Each GlobleModifiers is a Modifier that is added for the NPCs.

## Modifiers unlocking a miracle

Modifiers can unlock miracles for the NPC. Used with Fei and Lushu contracts.
```xml
<Modifier Name="Modifier_Horse_LuShu_0" Type="Normal" Parent="Modifier_Horse_All_0">
    <DisplayName>鹿蜀</DisplayName>
    <UnLockMagic>
        <li>PrayForSun_LuShuHorse</li>
    </UnLockMagic>
</Modifier>
```
Each UnLockMagic entry is a miracle that is made available for the target.