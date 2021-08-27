# Creating a new Diagram using existing nodes

The result for this example is a manual containing a new diagram made from existing nodes. This is a precursor for creating Ancient Formations.

The practical steps are easy, just add the ZhenShapes section with the diagram to a manual. As an example, here's Settings\Esoterica\Esoterica_ACS_M_EX_05.xml

```xml
<Esotericas><List>
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
</List></Esotericas>
```

That's it. To understand the ZhenShapes and ShapeInfo, check out the additional resources in the repository under Information.