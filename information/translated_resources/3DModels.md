# Custom Models

This is currently an attempt at translating the existing resources, it will be changed into a proper resource in the future.

## Modded Character Creation Instructions

### Supported functionalities

1. Character import can support players to import any model that can use "humanoid `Biped skeleton`" from outside.
2. The imported models can use all the movements of the humanoid characters in the game according to specification.
3. You can import all weapons that match the weapon grip of the game.

### Not Supported functionalities

1. Because the `Biped` skeleton animation of the character in the game is used, and the hair, sleeve and floating belt are animated with bone skeleton, so the animation of hair, big sleeve and skirt cannot be supported by the model imported from outside. So even if the player imports a model with hair, sleeves and other parts ov the skeleton, there is no floating animation when entering the game. But it can be imported.
2. Does not support the game to adjust the size of the character, so you need to adjust the size of the character you need in max before importing, the size of the character does not affect the animation reading.
3. Does not support the use of non-biped bone hierarchy and named bones (do not understand the bone hierarchy can wath 003 instructional video, 7 and 8 points of the content)

### Production ideas

NPC: open the model (fbx, obj, max, etc.) file using 3dmax, set up the standard skeleton, increase the skin, sticky the `TPose`, change the relationship between the two prop bones on the first level of bone, add weapons tie points, change the relative path of the mapping (or check the embedded media when exporting fbx). Export fbx to use.

Weapons: import the weapon model into `Weapons Export.max`, use the "Align command" to align the weapon coordinates with the example weapon, and change the relative path of the mapping (or check Embedded Media when exporting fbx). Export it.

Refer to the video for details on how to explain the above.

### Videos, divided into six parts.

- 001 Preface.mp4
- 002 Basic Max operations.mp4
- 003 Skeleton buiding and quick skinning.mp4
- 004 Character export.mp4
- 005 Weapon export.mp5
- 006 Model finishing instructions for models that already have skeletal skins

If you are completely inexperienced in game making and 3dsMax use:

Suggest you view them all in order

If you knnow hot to use max for skeleton and animation, and just want to import the model into the game, suggest you watch them in order, 004,005,007 two videos will do

If you have a model with bones and skins by default, then suggest you watch them in order 006, 007 004, 005

If you download the model with bones and skins after the specification changes are not correct to guide in, then suggest you watch video 008

All the videos have subtitles, if you can not hear, or the language is not clear enough to pause to see the subtitles, there are detailed shortcuts and buttons specific names and some nouns of the text. Easy to understand.

Video Link: https://www.bilibili.com/video/av61246158/

## Custom animal model creation

__Supported__

1. All types of skeletal animated animals are supported (humanoid and humanoid shapes can be imported as monsters in this way without problems)

__Not Supported__

1. Doesn't support the import of multiple individual action fbx files, a character needs to combine all actions into one fbx file
2. Doesn't support the use of the game's characters and demon animals animation, you need to make their own or download the shared free action reference

### Production ideas

Combine the existing animations into one max file, name and set the start and end frames of different animations in mad.

Change the relative path of the mapping (or check the embed media when exporting fbx)-

Export the fbx and use it in-game.

### Instruction videos

The animal import instructions video is divided into four parts.

- 001 Preface.mp4
- 002 Creation and adaptation of animal skeletons.mp4
- 003 Merging actions into a max file.mp4
- 004 Animal model skeleton and animation export instructions.mp4

There are only four videos, the content is relatively simple, please be patient to watch all of them. Maybe it will open up your production ideas.

All the videos are with subtitles, if you can't hear or express the language is not clear enough to pauese to see the subtitles, there are detailed shortcut keys and button specific names and some nouns in the text. It is convenient for everyone to understand.

Video Link: https://www.bilibili.com/video/av61251774/

## Weapon model creation

Video Link: https://www.bilibili.com/video/av61248330/

## All the tutorials from GSQ

Bilibili Link: https://space.bilibili.com/449602628

## Animal action naming convention

- atk - Attack action
- atk2 - Second attack
- dat - Getting struck
- die - Dying
- free - Leisure activities
- idle_loop - Standby loop
- run_loop - Moving loop
- sleep_loop - Sleeping loop
- _loop - Suffix of the action to be looped