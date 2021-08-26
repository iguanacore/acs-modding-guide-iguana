# Creating a new node using existing auxiliary links

The result for this example is a new node that uses existing auxiliary links. It also utilizes the previous example (ACS_M_EX_01), for the method of adding it to the game.

First, the directory structure for nodes:
Settings\Zhen\Node

In the Node folder, a new file was created, ZhenNode_ACS_M_EX.xml, which will contain the node. This is the content for that file, a Def containing the node.

```xml
<ZhenNodeDefs><List>
	<Def Name="ZhenNode_Lv1_Jian_2_1_ACS_M_EX" DisplayName="Paired Sword" Main="0" Base="2">
		<Lv>1</Lv>
		<Slot>
			<li SlotName="Lv1_Jian" Pos="0"/>
			<li SlotName="Lv1_Jian" Pos="5"/>
		</Slot>
	</Def>
</List></ZhenNodeDefs>
```

To utilize that node, either unlock it with a command or add it to a manual. A manual has been added containing that node. Here's the contents for that esoterica.

```xml
<Esotericas><List>
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
</List></Esotericas>
```