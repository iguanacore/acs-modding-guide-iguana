# Creating a new Truth of Formations

The result for this example is a new Truth of Formation utilizing existing auxiliary links. It also utilizes the first two examples for the methods of creating a new node (pillar) and adding it to a manual.

First, creating the SlotSuit_ACS_M_EX_04.xml under Settings\Zhen\SlotSuit and filling it with:

```xml
<Defs><List>
	<Def Name="SlotSuit_Jian_1_ACS_M_EX_04" DisplayName="Truth of Dull Sword " Base="0">
		<HideInUi>0</HideInUi>
        <Conditions>
            <li A="Lv1_Jian" B="Lv1_Jian" Count="4" />
        </Conditions>
		<SuitEffect>
			<li>
				<DisplayName></DisplayName>
				<Description>Artifact Mastery Ability Enhanced</Description>
				<SuitType>AddZhenProperty</SuitType>
				<TypeExtra>FabaoAtkPowerAddv</TypeExtra>
				<fParam1>5</fParam1>
			</li>
		</SuitEffect>
	</Def>
</List></Defs>
```

To have any use for that Truth of Formation, it needs to be added to a pillar. Now to add a custom pillar with that Truth of Formation, Settings\Zhen\Node\ZhenNode_ACS_M_EX_04_.xml

```xml
<ZhenNodeDefs><List>
	<Def Name="ZhenMainNode_Lv1_JianC_1_1_ACS_M_EX" DisplayName="Dull Sword Pillar" Main="1" Base="2">
		<Lv>1</Lv>
        <SlotSuits>
            <li>SlotSuit_Jian_1_ACS_M_EX_04</li>
        </SlotSuits>
		<Slot>
			<li SlotName="Lv1_Jian" Pos="0"/>
		</Slot>
	</Def>
</List></ZhenNodeDefs>
```

And a manual to unlock it ingame, Settings\Esoterica\Esoterica_ACS_M_EX_04.xml

```xml
<Esotericas><List>
    <Esoterica Name="ACS_M_EX_EsotericaZhenFa_4">
		<DisplayName>Formations: Example 04</DisplayName>
		<StarLevel>1</StarLevel>
		<Difficulty>1</Difficulty>
		<Desc>This is the description</Desc>
		<EffectDesc>This is the effect, formated.\nUnlocks Pillar: \nDull Sword Pillar</EffectDesc>
		<GLevel>Qi</GLevel>
		<Element>None</Element>
		<ZhenNodes>
			<li>ZhenMainNode_Lv1_JianC_1_1_ACS_M_EX</li>
		</ZhenNodes>
	</Esoterica>
</List></Esotericas>
```