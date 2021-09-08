# Experiences, or Perks

Experiences, also called Perks in exactly one image during Character Creation, can be used the change your starting experience.

For mods with added content, this is one way of making them available to the player, but it requires starting a new game.

Experiences are found in `Settings\Npc\Experience`, and are contained in `<Experiences>`, with a list containing `<Experience>`. Taking the SYS_LOST experience as a basic example:

```xml
<Experience Name="SYS_LOST">
    <DisplayName>模组丢失</DisplayName>
    <Desc>失落之物，没有人认识这个。\n（模组丢失）</Desc>
    <Point>0</Point>
    <Hide>1</Hide>
</Experience>
```

Experiences consist of the following properties, inheritance is possible but not used for existing Experiences.

- Name - Internal identifier, unique.
- Group - The group for the experience, only one experience out the group can be chosen.
- DisplayName - The name of the Experience, displayed in-game.
- RaceKind - Whether it's a `Human` or `YaoGuai` exclusive experience. Default value is Any, for both humans and yaoguai.
- Desc - The description of the Experience, displayed in-game.
- Point - The point cost of the Experience, adds points if it's negative.
- NpcSlot - Changes the amount of starting disciples.
- Hide - Whether the Experience is shown or not, setting it to `1` will make it hidden.
- ModifierDef - Works similarly to Modifiers, adds the effect to the First character in the list.
- IsMod - If it's set to `1`, then the Experience isn't used. Not found in any existing Experiences.
- Equips - The items equipped on First character in the list. Can consist of multiple entries, each entry being a single equipped item.
- Items - The items spawned on the ground at start. Can consist of multiple entries, each entry being a single item or stack.
- Gongs - The starting Gong(Law). Can consist of multiple entries, each entry being a single Gong.
- Esoterics - The starting Esoterica(Manuals). Can consist of multiple entries, each entry being a single Esoterica.
- Mutex - The mutually exclusive Experiences. Can consist of multiple entries, each entry being a single Experience. Not found in any existing Experiences.
- Recommend - Whether the Experience is Recommended to start with. Setting it to `1` will add the Recommendation.