# Three Custom Laws

This example contains a Law for each method of Cultivation. The three sections are split into two, the actual order, and the reasoning behind the actions taken.

The result are Laws somewhat comparable to existing ones in detail.

## The Basics

Starting with the usual, populating `info.json` and the required structures. No additional resources (images) are planned, just the definitions.

## Xiandao Law

For the Gong itself, a new file, at `Settings\Practice\Gong`, `ACS_M_EX_08_Gong1.xml`, and filling it with:

```xml
<Gongs><List>
	<Gong Name="ACS_M_EX_08_Gong_1_Shui">
		<DisplayName>First Law</DisplayName>
		<Desc>Description of the Law, a good place to put the Lore and the focus of it.</Desc>
		<SelectDesc>Description on Selection. Final warning towards the player, to make sure that they really want to select this Law.</SelectDesc>
		<FiveBaseNeed>-1, 7, 5, 6, -1</FiveBaseNeed>
		<SkillSetName></SkillSetName>
		<ElementKind>Shui</ElementKind>
		<Skill>
			<li>jiangdao</li>
			<li>ciqi</li>
			<li>guanding</li>
		</Skill>
    </Gong>
</List></Gongs>
```

The result is a Gong, but without any Stages. Adding the Stage attribute to that Gong, with four Stages, each with a single Neck at 100% completion. The Stages Attribute will consist of:

```xml
		<Stages>
			<Stage Name="Stage1" Level="3">
				<DisplayName>Qi Shaping</DisplayName>
				<Desc>The first stage, ending with a regular Chance Breakthrough.</Desc>
				<Value>1800</Value>
				<Necks>
					<Neck Location="1" Kind="Chance">
						<DisplayName>End of Qi Shaping</DisplayName>
						<Desc>Chance Breakthrough.</Desc>
						<CostTime>200</CostTime>
						<SuccessChange>1</SuccessChange>
						<AddModifier>Gong_Qi</AddModifier>
					</Neck>
				</Necks>
			</Stage>
			
			<Stage Name="Stage2" Level="6">
				<DisplayName>Core Shaping</DisplayName>
				<Desc>The second stage, ending with a Golden Core Forming Breakthrough.</Desc>
				<Value>4000</Value>
				<Necks>
					<Neck Location="1" Kind="Gold">
						<DisplayName>End of Core Shaping</DisplayName>
						<Desc>Golden Core Forming Breakthrough.</Desc>
						<AddModifier>Gong_Gold</AddModifier>
					</Neck>
				</Necks>
			</Stage>	
			
			<Stage Name="Stage3" Level="9">
				<DisplayName>Golden Core</DisplayName>
				<Desc>The third stage, ending with a Void Breakthrough.</Desc>
				<Value>300000</Value>
				<Necks>
					<Neck Location="1" Kind="Work">
						<DisplayName>End of Golden Core</DisplayName>
						<Desc>Void Breakthrough.</Desc>
						<AddModifier>Gong_Thunder2</AddModifier>
					</Neck>
				</Necks>
			</Stage>
			
			<Stage Name="Stage4" Level="12">
				<DisplayName>Primordial Spirit</DisplayName>
				<Desc>The final stage, ending with a Heavenly Tribulation.</Desc>
				<Value>6560000</Value>
				<Necks>
					<Neck Location="1" Kind="God">
						<DisplayName>End of Primordial Spirit</DisplayName>
						<Desc>Heavenly Tribulation.</Desc>
						<ThunderValue>520000</ThunderValue>
						<NeckCountdown>3000</NeckCountdown>
						<AddModifier>Gong_Thunder3</AddModifier>
					</Neck>
				</Necks>
			</Stage>
		</Stages>
```

For those familiar with existing Vanilla content, there should be a lot of similarities. Since it's a trimmed down version of Sixteen Supreme Steps Law.

While the Gong with the Stages and Necks is now implemented, the Inspiration Tree is up next. A new file, `Settings\Practice\Tree\ACS_M_EX_08_Gong1.xml`, and fill it with:

```xml
<SkillTree><List>	
	<Node Name="ACS_M_EX_08_Gong_1_Shui_a0" Gong="ACS_M_EX_08_Gong_1_Shui">
		<Esoterica>Magic_MakeHorse_1</Esoterica>
		<DisplayName>Make me a Horse</DisplayName>
		<Level>Qi</Level>
		<Index>0</Index>
        <Line>0,0,0,0,1,0,2,0</Line>
	</Node>
    <Node Name="ACS_M_EX_08_Gong_1_Shui_b0" Gong="ACS_M_EX_08_Gong_1_Shui">
		<Esoterica>Magic_BuidPuppet</Esoterica>
		<DisplayName>Make me a Worker</DisplayName>
        <PreUnit>
		<li>ACS_M_EX_08_Gong_1_Shui_a0</li>
		</PreUnit>
		<Level>Dan1</Level>
		<Index>0</Index>
	</Node>
		<Node Name="ACS_M_EX_08_Gong_1_Shui_1_e4" Gong="ACS_M_EX_08_Gong_1_Shui">
		<Esoterica>God2_Dan</Esoterica>
		<DisplayName>Eureka Pill</DisplayName>
		<Level>God2</Level>
		<Index>4</Index>
		<Skills>
			<li Name="Medicine" Level="20"/>
		</Skills>
	</Node>
	<Node Name="ACS_M_EX_08_Gong_1_Shui_1_e8" Gong="ACS_M_EX_08_Gong_1_Shui">
		<Esoterica>God2_Fabao</Esoterica>
		<DisplayName>Taoist Artifact</DisplayName>
		<Level>God2</Level>
		<Index>8</Index>
		<Skills>
			<li Name="Manual" Level="20"/>
		</Skills>
	</Node>
</List></SkillTree> 
```

Once again, a trimmed down version of Sixteen Supreme Steps Law with an important notice.

* Manual Name and Node Name differences - Something that you should avoid, but a technical possibility.

With those two files, there is now a custom Law with its own Inspiration Tree.

### A new Max Qi Manual

Since all Supreme Laws in Vanilla come with their own Max Qi increasing Manual, so will this one. Max Qi was chosen as a simple and easy to understand aspect.

Implementing a new Manual to an existing Tree comes in three parts. The Manual itself, the Modifiers it applies, and its place in the Inspiration Tree.

For the Manual, a new file, `Settings\Esoterica\ACS_M_EX_08_Gong.xml`, and fill it with:

```xml
<Esotericas><List>
    <Esoterica Name="ACS_M_EX_08_Gong_1_Esoterica_1">
		<DisplayName>Custom MQ Manual</DisplayName>
		<StarLevel>1</StarLevel>
		<Difficulty>3</Difficulty>
		<GLevel>Dan1</GLevel>
		<Desc>Add some Qi on them.</Desc>
		<Element>Shui</Element>
		<Type>None</Type>
		<EffectDesc>[size=10][color=#D06508]Does the Following\nIncreases Max Qi[/color][/size]</EffectDesc>
		<Modifier>ACS_M_EX_08_Gong_1_Esoterica_1</Modifier>	
	</Esoterica>
</List></Esotericas>
```

That adds the Manual. For the Modifier it applies, a new file, `Settings\Modifiers\ACS_M_EX_08_Modifier_Gong_Esoteriac.xml`, (yes, Esoteriac instead of Esoterica, to keep in line with the Vanilla spelling) and fill it with:

```xml
<ModifierDefs><List>
	<Modifier Name="ACS_M_EX_08_Gong_1_Esoterica_1" Type="Normal">
		<DisplayName>ACS_M_EX_08_Gong_1_Esoterica_1</DisplayName>
		<MaxStack>0</MaxStack>
		<Duration>-1</Duration>
		<Display>0</Display>
		<Properties>
			<li Name="NpcLingMaxValue" AddV="1000"/>
		</Properties>
	</Modifier>
</List></ModifierDefs>
```

Since additional balancing/exclusivity isn't planned for this example, those two files have provided the Manual with its effect. For adding it into the Inspiration Tree, a new Node will need to be created under `Settings\Practice\Tree\ACS_M_EX_08_Gong1.xml`, and to keep in line with the original ordering (Index values incrementing, then the Level values), it will go after `ACS_M_EX_08_Gong_1_Shui_b0`. The added Node consists of:

```xml
<Node Name="ACS_M_EX_08_Gong_1_Shui_b5" Gong="ACS_M_EX_08_Gong_1_Shui">
	<Esoterica>ACS_M_EX_08_Gong_1_Esoterica_1</Esoterica>
	<DisplayName>Custom MQ Manual</DisplayName>
	<Level>Dan1</Level>
	<Index>5</Index>
</Node>
```

And with those three additions, a New Manual has been created and added to the Inspiration Tree of the Custom Law. This is where the Xiandao Example currently ends.

### Xiandao Balancing

To dissect the above, the following points (added in the future):

* Law Aspects
* Stages and Necks
* Inspiration Tree
* Manuals
* Modifiers

## Shendao Law

* Law Itself
* Stages and Necks
* Guards and related Modifiers

### Shendao Balancing

* Law Aspects
* Stages and Necks
* Guards

## Physical Law

* Law Itself
* Stages and Necks
* Secret Bodies