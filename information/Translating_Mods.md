# Translating Mods

This document is about translating existing mods and preparing your own mods for translation.

## Preparing a mod for translation

This is how it's supposed to be done. Imagine you're a Chinese mod maker and you've completed your mod, now you want to make it usable by the English community.

First, use StringTool.exe in the Mods folder to generate translation files for everything .xml, the tool itself is simple.

1. Run StringTool.exe
2. Enter the folder name for the mod you wish to translate (which is also the mod Name according to info.json)
3. Click on the button and wait until it goes through the files
4. After it's gone through all files it will open a popup with Finished, close the window
5. A window will open with the translated files, you can now close StringTool.exe
6. Go through the files created and replace the Chinese into English

If any errors occur, solve them. If you can't solve them, compress the files and email them to qa@gsqstudio.com .

After the .xml has been dealt with, the next item is .lua files, if they use any displayable strings.

For .lua, you need to add the `XT()` for all strings. This means turning

`“中文”`

into

`XT(“中文”)`

After all the strings have been modified, populate a MapStoryDictionary.txt with those values. It's a text file in Language\OfficialEnglish, it's made up of a Key/Value list. Similarly to the one below.

If you are unsure of the format, use a spreadsheet application, copy an existing MapStoryDictionary and do your changes in there. When complete, just paste the entries directly in that text file.

Key|Value
-|-
中文|String

To translate your mod for other languages, rename the OfficialEnglish to the language you're translating to. Theoretically, that's how it's supposed to work.

## Reality

Looking at a large amount of existing translated mods, that's not how things are done. For those mods, it seems as if the order has been:

1. Create a copy of the mod
2. Replace any Chinese strings with their English versions, usually through Google Translate

This technically works. And if someone wants to translate it into another language, they also need to change the base files for everything.

This needs to be redone with every update, if it's unknown what the exact changes were.

Avoid doing this for mods you wish to translate.

If you wish to translate a mod done by someone, get their permission if you wish to publish it. Then, just follow the steps:

1. Get a local copy of the mod
2. Run StringTool.exe for the content
3. Verify the content created by StringTool, ensure that the needed strings exist in the created files
4. Translate the string created by StringTool
5. Go over the scripts, including the MapStories and other sources for them, surround the strings with XT()
6. Populate the MapStoryDictionary with the entries, add translations for them
7. Verify the work done, test the mod in-game

You have now translated a mod.

# Language Packs

If you wish to localize ACS into a new language, it's possible to do so, there's documentation in the Mods folder (Language Pack).

A new language pack is functionally a mod. Start with a basic structure, create a new folder in the Mods directory, and add populate the `info.json` with the values.

1. Copy the language files from the Example Mod into your newly created mod, either `Example\Language\ChineseSource` or `Example\Language\EnglishSource`. At this point your Mod will contain the `info.json`, and `Language\LanguageSource`, rename the LanguageSource into the language you're converting into, as an example, `RussianSource`.
2.  Create a Config.xml in the Mod\Language folder, and configure it similarly to the one in the Example mod. An example is below:
```xml
<Languages><List>
    <Language Name="RussianSource">
        <DisplayName>Russian Language</DisplayName>
        <Icon>ruflag</Icon>
        <UIMode>1</UIMode>
        <Desc>Russian Translation</Desc>
        <SpaceConnect>true</SpaceConnect>
        <FamilyPostposition>true</FamilyPostposition>
</List></Languages>
```
The name in the xml and the name of the folder in Language must be identical.
3. Replace the Chinese\English strings in all the files. For the dictionaries, change only the Values and not Keys.
4. Test it. If no errors exist, publish it.

Additional remarks from the original file:

- `CodeDictionary.txt` and `MapStoryDictionary.txt` must be UTF-8 encoded.
- The reincarnator file will be overwritten, please customize it for different languages.
- For more details please e-mail : `MOD@gsqstudio.com`