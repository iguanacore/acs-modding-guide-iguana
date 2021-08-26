# Unlocking nodes with manuals
The result for this example is a new manual (or <Esoterica>) that unlocks some unused nodes. It doesn’t introduce ways of acquiring the manual.

With the created mod, the first step is to replicate the existing directory structure for esoterica. In the mod folder, the following structure was created:

Settings\Esoterica

In the Esoterica folder, a new file was created, Esoterica_ACS_M_EX.xml, which will contain the manual. This is the content for that file, an <Esoterica> entry, containing the <ZhenNodes> that will be unlocked.

```xml
<Esotericas><List>
    <Esoterica Name="ACS_M_EX_EsotericaZhenFa_1">
        <DisplayName>Formations: Addendum</DisplayName>
        <StarLevel>1</StarLevel>
        <Difficulty>1</Difficulty>
        <Desc>This is the description</Desc>
        <EffectDesc>This is the effect, formated.\nUnlocks Pillar: \nProto-pillar: Turn\nProto-pillar: Curve\nProto-pillar: Link\nProto-pillar: Tip\nProto-pillar: Row</EffectDesc>
        <GLevel>Qi</GLevel>
        <Element>None</Element>
        <ZhenNodes>
            <li>ZhenMainNode_Lv0_3_2</li>
            <li>ZhenMainNode_Lv0_3_3</li>
            <li>ZhenMainNode_Lv0_3_4</li>
            <li>ZhenMainNode_Lv0_4_2</li>
            <li>ZhenMainNode_Lv0_4_3</li>
        </ZhenNodes>
    </Esoterica-->
</List></Esotericas>
```