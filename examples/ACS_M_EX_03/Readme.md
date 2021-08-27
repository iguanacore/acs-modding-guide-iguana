# Creating a new type of auxiliary link

The result for this example is a new node that uses new auxiliary links. It utilizes the first two examples, for the methods of creating a new node and adding it to a manual.

First is adding a new file, ACS_M_EX_03_nodetypeinfo.xml, under Settings\Zhen\NodeTypeInfo, the contents for it are as follows.

```xml
<Defs><List>
    <Def Name="Lv1_Jin" DisplayName="金"></Def>
    <Def Name="Lv1_Mu" DisplayName="木"></Def>
    <Def Name="Lv1_Shui" DisplayName="水"></Def>
    <Def Name="Lv1_Huo" DisplayName="火"></Def>
    <Def Name="Lv1_Tu" DisplayName="土"></Def>
</List></Defs>
```

With five new Lv1 auxiliary links defined, the next step is defining their effects, for both auxiliaries and pillars. That is done with a new file, ACS_M_EX_03_ZhenSlot.xml, under Settings\Zhen\Slot, the contents for it are as follows.

```xml
<ZhenSlotDefs><List>
	<Def Name="Lv1_Jin" DisplayName="金">
		<Lv>1</Lv>
		<SlotType>Lv1_Jin</SlotType> 
		<Effect>
		<li Type="SheildBasev" Value="3" />
		</Effect>
		<CoreEffect>
		<li Type="SheildAddp" Value="0.5" />
		</CoreEffect>
	</Def>
    <Def Name="Lv1_Mu" DisplayName="木">
		<Lv>1</Lv>
		<SlotType>Lv1_Mu</SlotType>
		<Effect>
		<li Type="StabilityBasev" Value="5" />
		</Effect>
		<CoreEffect>
		<li Type="StabilityAddp" Value="0.5" />
		</CoreEffect>
	</Def>
    <Def Name="Lv1_Shui" DisplayName="水">
		<Lv>1</Lv>
		<SlotType>Lv1_Shui</SlotType>
		<Effect>
		<li Type="FabaoAtkPowerBasev" Value="5" />
		</Effect>
		<CoreEffect>
		<li Type="FabaoAtkPowerAddp" Value="0.5" />
		</CoreEffect> 
	</Def>
    <Def Name="Lv1_Huo" DisplayName="火">
		<Lv>1</Lv>
		<SlotType>Lv1_Huo</SlotType> 
		<Effect>
		<li Type="MagicPowerBasev" Value="5" />
		</Effect>
		<CoreEffect>
		<li Type="MagicPowerAddp" Value="0.5" />
		</CoreEffect>
	</Def>
    <Def Name="Lv1_Tu" DisplayName="土">
		<Lv>1</Lv>
		<SlotType>Lv1_Tu</SlotType> 
		<Effect>
		<li Type="StabilityBasev" Value="5" />
		</Effect>
		<CoreEffect>
		<li Type="StabilityAddp" Value="0.5" />
		</CoreEffect>
	</Def>
</List></ZhenSlotDefs>
```

At this point there are five custom link types with both auxiliary and pillar effects. They can now be utilized for custom nodes. Now, creating a new pillar and an auxiliary using those nodes. Create the Settings\Zhen\Node folder, and ZhenNode_ACS_M_EX_03.xml inside it.

```xml
<ZhenNodeDefs><List>
	<Def Name="ZhenMainNode_Lv1_custom_5_1_ACS_M_EX" DisplayName="Vacant Elements" Main="1" Base="2"> <!-- No SlotSuits yet --> 
		<Lv>1</Lv>
		<Slot>
			<li SlotName="Lv1_Jin" Pos="0"/>
			<li SlotName="Lv1_Shui" Pos="1"/>
            <li SlotName="Lv1_Mu" Pos="2"/>
            <li SlotName="Lv1_Tu" Pos="3"/>
            <li SlotName="Lv1_Huo" Pos="4"/>
		</Slot>
	</Def>
    <Def Name="ZhenNode_Lv1_Jin_1_1_ACS_M_EX" DisplayName="Metal" Main="0" Base="2">
		<Lv>1</Lv>
		<Slot>
			<li SlotName="Lv1_Jin" Pos="0"/>
		</Slot>
	</Def>
        <Def Name="ZhenNode_Lv1_Shui_1_1_ACS_M_EX" DisplayName="Water" Main="0" Base="2">
		<Lv>1</Lv>
		<Slot>
			<li SlotName="Lv1_Shui" Pos="0"/>
		</Slot>
	</Def>
        <Def Name="ZhenNode_Lv1_Mu_1_1_ACS_M_EX" DisplayName="Wood" Main="0" Base="2">
		<Lv>1</Lv>
		<Slot>
			<li SlotName="Lv1_Mu" Pos="0"/>
		</Slot>
	</Def>
        <Def Name="ZhenNode_Lv1_Tu_1_1_ACS_M_EX" DisplayName="Earth" Main="0" Base="2">
		<Lv>1</Lv>
		<Slot>
			<li SlotName="Lv1_Tu" Pos="0"/>
		</Slot>
	</Def>
        <Def Name="ZhenNode_Lv1_Huo_1_1_ACS_M_EX" DisplayName="Fire" Main="0" Base="2">
		<Lv>1</Lv>
		<Slot>
			<li SlotName="Lv1_Huo" Pos="0"/>
		</Slot>
	</Def>
</List></ZhenNodeDefs>
```

To utilize the nodes, either unlock them with a command or add them to a manual. A manual has been added containing them. Here's the contents for that esoterica.

```xml
<Esotericas><List>
    <Esoterica Name="ACS_M_EX_EsotericaZhenFa_3">
		<DisplayName>Formations: Example 03</DisplayName>
		<StarLevel>1</StarLevel>
		<Difficulty>1</Difficulty>
		<Desc>This is the description</Desc>
		<EffectDesc>This is the effect, formated.\nUnlocks Pillar: \nVacant Elements\n\nUnlocks Auxiliary: \nMetal\nWater\nWood\nEarth\nFire</EffectDesc>
		<GLevel>Qi</GLevel>
		<Element>None</Element>
		<ZhenNodes>
			<li>ZhenMainNode_Lv1_custom_5_1_ACS_M_EX</li>
            <li>ZhenNode_Lv1_Jin_1_1_ACS_M_EX</li>
            <li>ZhenNode_Lv1_Shui_1_1_ACS_M_EX</li>
            <li>ZhenNode_Lv1_Mu_1_1_ACS_M_EX</li>
            <li>ZhenNode_Lv1_Tu_1_1_ACS_M_EX</li>
            <li>ZhenNode_Lv1_Huo_1_1_ACS_M_EX</li>
		</ZhenNodes>
	</Esoterica>
</List></Esotericas>
```