# Inspiration Tree

This document is about Inspiration Trees, a Xiandao Gong specific feature. Inspiration Trees contain the Esoterica for the law, also shown in the Meditate Law window.

Inspiration Trees are located under `Settings\Practice\Tree`, each contains a `<SkillTree>`, containing a List of Nodes. Each Node is a single entry. And unless GSQ releases a tool to create them or implements them into the Content Editor, this is the worst part about creating a custom Xiandao Gong.

An example of a single Node, from 16 Steps, Seal Contract.
```xml
<SkillTree><List>	
	<Node Name="Gong1_a0" Gong="Gong_1_Shui">
		<Esoterica>Magic_MakeHorse_1</Esoterica>
		<DisplayName>封灵术</DisplayName>
		<Level>Qi</Level>
		<Index>0</Index>
	<!--	<Layers>
			<li>Gong1_a1_2</li>
			<li>Gong1_a1_3</li>
		</Layers>-->
		<Line>0,0,0,0,0,0,0,0</Line>
		<PreUnit>
		<!--	<li></li>-->
		</PreUnit>
		<MutexUnit>
		<!--	<li></li>-->
		</MutexUnit>
		<FiveBase>0,0,0,0,0</FiveBase>
		<Skills>
			<!--<li Name="" Level="1"/>-->
		</Skills>
		<LingMax>0</LingMax>
		<GoldLevel>0</GoldLevel>
		<GodCount>0</GodCount>
	</Node>
</List></SkillTree>
```

A Node can consist of the following properties:

- Name - The name of the Node, must be unique.
- Gong - The Gong the Node belongs to. Must be an existing Gong.
- Parent - The parent of the Gong, can make it inherit values.
- Esoterica - The Esoterica provided by the Node.
- DisplayName - The name of the Node shown ingame, should be the same as the name of the Esoterica (but isn't always).
- Level - The required stage, uses the `g_emGongStageLevel` values (`None`, `Qi`, `Dan1`, `Dan2`, `God`, `God2`). Also used for the position of the node on the Y axis.
- Index - The position of the Node on the X axis, an integer between 0 (left most position) and 11 (right most position)
- Line - The connecting lines between Nodes. Explained in detail below.
- PreUnit - A learning pre-requisite for the Node, can have multiple PreUnits with a single Node.
- MutexUnit - Mutually exclusive Nodes, can have multiple MutexUnits with a single Node, needs to be added for all Nodes that are mutually exclusive with each other.
- Skills - A Skill level requirement for learning the Node, seen with the two Demi-god level Nodes.
- LingMax - A Max Qi requirement for learning the Node.
- GoldLevel - A Golden Core Tier requirement for learning the Node.
- GodCount - A Primordial Spirit count requirement for learning the Node.
- FiveBase - The Base stat requirement for learning the Node.
- DaoHang - The Attainment requirement for learning the Node.
- Layers - Used for placing multiple Nodes behind a single Node, also called Advanced manuals by some. For the Nodes contained within layers, Index and Level isn't used.
- Depth - Used for the Yin Yang laws, a value of `1` is used for the alternative manuals displayed.

## Lines

The `<Line>` property is used to draw lines between the nodes. It consists of a string, eight numbers seperated by a comma. Each of the numbers represents a value from the `UI_TreeLine` list. In order, it's:

m_B0, m_B1, m_B2, m_B3, m_S0, m_S1, m_S2, m_S3

Until someone reaches understanding of how the lines are formed, your best bet is to keep the Trees simple and use known layouts. For example, **Arrow Below:**

`<Line>0,0,0,0,1,0,2,0</Line>`

The existing Trees also use empty nodes that consist of just Lines, in order to make more complex shapes.

Your best bet is to see what the existing Tree Nodes look like and imitate them.