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

The above is a good way to get **started**, but for a proper addition, the following needs to be taken into consideration:

#### Law Aspects

Starting with the Gong specific Attributes. Descriptions, Names, and so on. An easy way of lowering the quality is having spelling errors contained in those. A suggestion for temporary strings, use prefixes.

Searching for specific characters should ensure that no left-over strings get included in the released version. Or at least reduce the possibility.

* `FiveBaseNeed` - Do you plan on using the Law Matching Attribute in additional ways (like the vanilla Advanced Xiandao Gongs)? Then a simple sanity check would be wise. Avoid having Events requiring an impossible Law Matching value.
* `ElementKind` - The Element of Law has multiple aspects. Artifact Connectivity, Cultivation/Breakthrough Timings, use in Events, Formation Requirements and Connectivity, Manual Connectivity, the impact of a single string is major. Until a design document or a similar resource for Elemental Preferences (Metal for Artifact Mastery, Fire for Spell, or the opposite) is created, either go wild, or follow vanilla examples.
* `Hide` -  Is the Gong supposed to be *visible* from Day 1? If not, a value of 1 will ensure that it's not shown as one of the *Locked* Laws.
* `IllustratedHandLabel` - Want to avoid cluttering the Codex? Set it to `Dele`
* `YinYang` - Are you prepared to create a dual-layer Inspiration Tree, and want to make another Yin/Yang Law? Additional work is required as well, since Law of Nimbus Conquest comes with additional aspects not clearly explained. Avoid it for your first creations.
* `Skill` - IMB Miracles/Effects, Branch Management method Bonus. There is *some* logic for assigning. If there are no Combat related aspects for the Gong, `Chumo`/Exorcise doesn't make sense. Or for `Cuiti`/Remold, when Alchemy/Remolding/Healing aren't included in any way. Check the Vanilla values, those are easy to get inspired by.

#### Stages and Necks

After the previous have been polished, Stages and Necks. Starting with the overall concept of the Stages.

There are **multiple** ways of looking at Stages. Looking at two reasonable extremes, four and twelve stages. 

With four, the stages would correspond with Xiandao Stage names (Qi Shaping, Core Saping, etc.), an example would be Sixteen Supreme Steps Law. 
With twelve, the stages would correspond with Unorthodox Xiandao Stage Names.

Those are the **reasonable** extremes. It should be possible to go beyond those, with less, or even more Stages. Technical limits are one thing, design aspects are another. For making a Gong stand out, going beyond the existing boundaries is a sure way of accomplishing it.

* `DisplayName` and `Desc` - An easy way of polishing. Avoid mixing up between the Stage values and Neck values.
* `Level` - To keep in line with vanilla, when there's a single Stage, use the peak value. With Four Stages, the result would be 3,6,9,12. If you don't plan on following the vanilla values, then be prepared for unexpected results.
* `Value` - How long should someone be on the same Stage? Are there any differences in XP gains compared to vanilla methods? How does your creation compare to vanilla values? Should you care? More questions than answers, all that you need to find out for yourself.

Now for `Necks`, which brings up further design aspects. What are the Limits that the Cultivator is breaking through? How does breaking through the Limit influence the Cultivator?

From a technical point of view, it's quite simple. But once you add the lore into the equation, it can become extremely complex. Especially if you consider the full structure of a `Neck`. An example, `ItemCost` is an Item that gets consumed for the breakthrough. `AddModifier` adds a Modifier after breaking through. It's possible to add Scripts to Modifiers. The result?

A Stage where the Cultivator has their Model set to a specific Animal, with new Race specific Modifiers (Barrier for Turtle, Adventure Speed for Rabbit, etc.) until the next Stage. Technically possible, just some Modifiers and Scripts. But if you have no desire to be that different, sticking with vanilla values is and always will be a possibility.

#### Inspiration Tree

Until a custom utility exists for creating Inspiration Trees, it would be easier to use external tools for planning the Tree. Keep in mind:

* Node or Esoterica - Inspiration Tree consists of Nodes. Nodes have an assigned Esoterica. While there are values that **should** be similar or even identical (`DisplayName` mostly), **don't mix up Node and Esoterica attributes**. Manual Pavilion and Mentoring allows the Esoterica to exist outside of the Inspiration Tree. If the Node has a `PreUnit` that is missing from the `Esoterica`, it will be possible to skip the pre-requisite through alternate means.
* `Lines` - Use Lines when the main structure is done. Adds visual polish, can be avoided in the beginning.

#### Manuals

Esoterica are an important point for balancing. Due to the Manual Pavilion and Mentoring aspects, a lot needs to be considered at once.

* `Difficulty` - Attainment Cost. Increasing it will increase the amount of overall Orthodox Attainment possible, allowing for more Unorthodox Attainment for everyone.
* `Type` - Category under Manual Pavilion should be the first thing that comes to mind. But there's another with a greater effect, Sub-Spirit Attachment Category. Should you make it attachable? Because unlike what the Sub-Spirit guide says on the topic, the category is what's important, not what it does. A Max Qi increasing manual within `Gong` category can be attached. Or if it contains Recipes/Miracles.
* `GLevel` - State requirement, when learnt through the regular methods. Can be ignored when used in alternative ways, like acquiring it after breaking through a Neck.
* `Hide` - In alternative terminology, making the Manual Law Exclusive. You **don't** need to use Node Layers together with Hide, a single Layer Node can be a Law Exclusive Manual. Opposite is true as well, Layered Nodes don't need to be Law Exclusive. To avoid boosting Max Qi to Pre-GC Sun Pill levels, making those particular Manuals Law Exclusive can be a reasonable option. It will also make the Law more *unique*.
* `Element` - How should Manual Element relate to Law Element? That would depend on the Manual in question. If you have no ideas on that topic, stick to `None`. Or a reasonable alternative, identical to the Law Element.
* `Mutex` - Mutually Exclusive Manuals can be hard to keep track of. Both during the development period, as well as regular gameplay. Don't use it lightly.
* `PreNeed` - Similarly to `Mutex` Manuals. If you aren't sure about the attribute, ignore it.
* Effect - What effect does learning the Manual have on the Cultivator? If it's not a Law Exclusive Manual, how does it fit with Cultivators using other Laws? If it has the same effect as an existing Manual, what happens when a Cultivator learns both Manuals? What's the purpose of that particular Manual?

#### Modifiers

Once Manuals/Esoterica has been cleared up, the final aspect that needs balancing, Modifiers. With Laws/Gongs, there are different types that need to be considered:

* Modifiers from breaking through Necks
* Modifiers from Esoterica
* Modifiers used for breaking through Necks (`SuccessChange` and `FailedChangeAdd`)
* Modifiers used for failing breakthroughs (`FailModifier`)

For making things simple, follow vanilla methods and stick to the first two types. Further simplification can be achieved by utilizing existing Modifiers gained from breaking through Necks.

But if you want to make your creation stand out, Modifiers are a good way of accomplishing it.

A Neck that adds a Modifier to reduce Cultivation Speed Bonus to zero, forcing the Cultivator to use alternative means of gaining Cultivation XP (Miracles, Adventures), and another Neck with its own Modifier that has a script to clear the previous Modifier.

After reaching this point in balancing, start again at the beginning. Look at the aspects another time, now being aware of a greater picture. The Gong, Inspiration Tree, Manuals, and Modifiers. Is there anything that could fit better in another category? A Manual with an attached Modifier that would be more suitable as a Modifier attached to a Breakthrough, or the opposite perhaps.

And after a few such passes, the result should be an Unique Balanced Custom Law. 

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