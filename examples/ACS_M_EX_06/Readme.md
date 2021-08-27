# Creating a new Ancient Formation

The result for this example is a manual containing a new Ancient Formation. And the other required parts to achieve that.

There are many methods of achieving the end result, this example will go with the most complex, custom auxiliary links, custom Truth of Formations, custom nodes with conditions, and a new ZhenSuitDef.

First, custom auxiliary links, similar to the ones used by ACS_M_EX_03, Settings\Zhen\NodeTypeInfo\ACS_M_EX_06_nodetypeinfo.xml

```xml
<Defs><List>
    <!-- LV 5-->
    <Def Name="Lv5_Jin" DisplayName="金"></Def>
    <Def Name="Lv5_Mu" DisplayName="木"></Def>
    <Def Name="Lv5_Shui" DisplayName="水"></Def>
    <Def Name="Lv5_Huo" DisplayName="火"></Def>
    <Def Name="Lv5_Tu" DisplayName="土"></Def>
</List></Defs>
```

And their effects, Settings\Zhen\Slot\ACS_M_EX_06_ZhenSlot.xml

```xml
<ZhenSlotDefs><List>
	<Def Name="Lv5_Jin" DisplayName="金"> <!-- Metal-->
		<Lv>5</Lv>
		<SlotType>Lv5_Jin</SlotType> 
		<Effect>
		<li Type="ReduceCostBasev" Value="5" />
		<li Type="SheildBasev" Value="3" />
		</Effect>
		<CoreEffect>
		<li Type="ReduceCostAddp" Value="0.5" />
		<li Type="SheildAddp" Value="0.5" />
		</CoreEffect>
	</Def>
    <Def Name="Lv5_Mu" DisplayName="木"> <!-- Wood-->
		<Lv>5</Lv>
		<SlotType>Lv5_Mu</SlotType>
		<Effect>
		<li Type="ReduceCostBasev" Value="5" />
		<li Type="StabilityBasev" Value="5" />
		</Effect>
		<CoreEffect>
		<li Type="ReduceCostAddp" Value="0.5" />
		<li Type="StabilityAddp" Value="0.5" />
		</CoreEffect>
	</Def>
    <Def Name="Lv5_Shui" DisplayName="水"> <!-- Water-->
		<Lv>5</Lv>
		<SlotType>Lv5_Shui</SlotType>
		<Effect>
		<li Type="ReduceCostBasev" Value="5" />
		<li Type="FabaoAtkPowerBasev" Value="5" />
		</Effect>
		<CoreEffect>
		<li Type="ReduceCostAddp" Value="0.5" />
		<li Type="FabaoAtkPowerAddp" Value="0.5" />
		</CoreEffect> 
	</Def>
    <Def Name="Lv5_Huo" DisplayName="火"> <!-- Fire-->
		<Lv>5</Lv>
		<SlotType>Lv5_Huo</SlotType> 
		<Effect>
		<li Type="ReduceCostBasev" Value="5" />
		<li Type="MagicPowerBasev" Value="5" />
		</Effect>
		<CoreEffect>
		<li Type="ReduceCostAddp" Value="0.5" />
		<li Type="MagicPowerAddp" Value="0.5" />
		</CoreEffect>
	</Def>
    <Def Name="Lv5_Tu" DisplayName="土"> <!-- Earth-->
		<Lv>5</Lv>
		<SlotType>Lv5_Tu</SlotType> 
		<Effect>
		<li Type="ReduceCostBasev" Value="5" />
		<li Type="StabilityBasev" Value="5" />
		</Effect>
		<CoreEffect>
		<li Type="ReduceCostAddp" Value="0.5" />
		<li Type="StabilityAddp" Value="0.5" />
		</CoreEffect>
	</Def>
	<Def Name="Lv5_Kong" DisplayName="空"> <!-- Sky -->
		<Lv>5</Lv>
		<SlotType>Lv5_Kong</SlotType> 
		<Effect>
		<li Type="ReduceCostBasev" Value="5" />
		<li Type="SheildBasev" Value="5" />
		<li Type="SkillCooldownBasev" Value="5" />
		</Effect>
		<CoreEffect>
		<li Type="ReduceCostAddp" Value="0.5" />
		<li Type="SheildAddp" Value="0.5" />
		<li Type="SkillCooldownAddp" Value="0.5" />
		</CoreEffect>
	</Def>
</List></ZhenSlotDefs>
```

After the links have been defined, time for custom nodes utilizing those links, in Settings\Zhen\Node\ACS_M_EX_06_ZhenNode_Suit.xml

```xml
<ZhenNodeDefs><List>
    <Def Name="ACS_M_EX_06_weather_0" DisplayName="Weather Controller" Main="1" Base="0">
		<SlotSuits>
			<li>ACS_M_EX_06_SlotSuit_weather_1</li>
		</SlotSuits>
		<Lv>5</Lv>
		<Slot>
            <li SlotName="Lv5_Jin" Pos="0"/>
			<li SlotName="Lv5_Shui" Pos="1"/>
			<li SlotName="Lv5_Mu" Pos="2"/>
			<li SlotName="Lv5_Tu" Pos="3"/>
			<li SlotName="Lv5_Huo" Pos="4"/>
		</Slot>
		<Suit>
			<li>
				<Condition>
					<li>
						<GongKindCondition GongKind="Shui"/>
                        <EsotericaNeed>Magic_PrayForWeather</EsotericaNeed>
					</li>
				</Condition>
				<SuitName>ACS_M_EX_06_weather</SuitName>
				<V>0</V>
			</li>
		</Suit>
	</Def>
    <Def Name="ACS_M_EX_06_weather_1" DisplayName="Thunderstorm" Main="0" Base="0">
		<Lv>5</Lv>
		<Slot>
            <li SlotName="Lv5_Kong" Pos="0"/>
			<li SlotName="Lv5_Jin" Pos="1"/>
			<li SlotName="Lv5_Kong" Pos="2"/>
		</Slot>
		
		<Suit>
			<li>
				<Condition>
					<li>
						<EsotericaNeed>Magic_PrayForLightningStorm</EsotericaNeed>
					</li>
				</Condition>
				<SuitName>ACS_M_EX_06_weather</SuitName>
				<V>1</V>
			</li>
		</Suit>
	</Def>
    <Def Name="ACS_M_EX_06_weather_2" DisplayName="Rainstorm" Main="0" Base="0">
		<Lv>5</Lv>
		<Slot>
            <li SlotName="Lv5_Kong" Pos="0"/>
			<li SlotName="Lv5_Shui" Pos="1"/>
			<li SlotName="Lv5_Kong" Pos="2"/>
		</Slot>
		
		<Suit>
			<li>
				<Condition>
					<li>
						<EsotericaNeed>Magic_PrayForRainstorm</EsotericaNeed>
					</li>
				</Condition>
				<SuitName>ACS_M_EX_06_weather</SuitName>
				<V>2</V>
			</li>
		</Suit>
	</Def>
    <Def Name="ACS_M_EX_06_weather_3" DisplayName="Toxic Miasma" Main="0" Base="0">
		<Lv>5</Lv>
		<Slot>
            <li SlotName="Lv5_Mu" Pos="0"/>
            <li SlotName="Lv5_Kong" Pos="1"/>
		</Slot>
		
		<Suit>
			<li>
				<Condition>
					<li>
						<EsotericaNeed>Magic_PrayForMiasma</EsotericaNeed>
					</li>
				</Condition>
				<SuitName>ACS_M_EX_06_weather</SuitName>
				<V>3</V>
			</li>
		</Suit>
	</Def>
    <Def Name="ACS_M_EX_06_weather_4" DisplayName="Foehn Wind" Main="0" Base="0">
		<Lv>5</Lv>
		<Slot>
            <li SlotName="Lv5_Kong" Pos="0"/>
			<li SlotName="Lv5_Huo" Pos="1"/>
		</Slot>
		
		<Suit>
			<li>
				<Condition>
					<li>
						<EsotericaNeed>Magic_PrayForFohn</EsotericaNeed>
					</li>
				</Condition>
				<SuitName>ACS_M_EX_06_weather</SuitName>
				<V>4</V>
			</li>
		</Suit>
	</Def>
    <Def Name="ACS_M_EX_06_weather_5" DisplayName="Dust Devil" Main="0" Base="0">
		<Lv>5</Lv>
		<Slot>
            <li SlotName="Lv5_Kong" Pos="0"/>
			<li SlotName="Lv5_Tu" Pos="1"/>
			<li SlotName="Lv5_Kong" Pos="2"/>
		</Slot>
		
		<Suit>
			<li>
				<Condition>
					<li>
						<EsotericaNeed>Magic_PrayForDustStorm</EsotericaNeed>
					</li>
				</Condition>
				<SuitName>ACS_M_EX_06_weather</SuitName>
				<V>5</V>
			</li>
		</Suit>
	</Def>
</List></ZhenNodeDefs>
```

Now the Truth of Formation for the pillar, under Settings\Zhen\SlotSuit\ACS_M_EX_06_SlotSuit.xml

```xml
<Defs><List>
	<Def Name="ACS_M_EX_06_SlotSuit_weather_1" DisplayName="Truth of Clear Weather" Base="0">
		<HideInUi>1</HideInUi>
		<SuitEffect>
			<li>
				<DisplayName></DisplayName>
				<Description>Formation Efficiency Increased</Description>
				<SuitType>AddZhenProperty</SuitType>
				<TypeExtra>ReduceCostAddv</TypeExtra>
				<fParam1>36</fParam1>
			</li>
			<li>
				<DisplayName></DisplayName>
				<Description>Operation Ability Enhanced</Description>
				<SuitType>AddZhenProperty</SuitType>
				<TypeExtra>SkillCooldownAddv</TypeExtra>
				<fParam1>36</fParam1>
			</li>
			<li>
				<DisplayName></DisplayName>
				<Description>Protection Ability Enhanced</Description>
				<SuitType>AddZhenProperty</SuitType>
				<TypeExtra>SheildAddv</TypeExtra>
				<fParam1>36</fParam1>
			</li>
		</SuitEffect>
	</Def>
</List></Defs>
```

At this point there are two things missing, the Ancient Formation data, and the manual containing the shape. The Ancient Formation data, under Settings\Zhen\Suit\ACS_M_EX_06_ZhenSuit.xml

```xml
<ZhenSuitDefs><List>
    <Def Name="ACS_M_EX_06_weather" DisplayName="Weather Clearing Formation">
		<Description>A formation focusing on clearing the weather, improving cultivation.</Description>
		<NodeName>
			<li>Weather Controller</li>
			<li>Thunderstorm</li>
			<li>Rainstorm</li>
			<li>Toxic Miasma</li>
			<li>Foehn Wind</li>
            <li>Dust Devil</li>
		</NodeName>
		<SuitEffect>
			<li>
				<RequireCount>2</RequireCount>
				<DisplayName></DisplayName>
				<Description>护御能力额外提高</Description>
				<SuitType>AddZhenProperty</SuitType>
				<TypeExtra>SheildAddv</TypeExtra>
				<fParam1>36</fParam1>
			</li>
			<li>
				<RequireCount>3</RequireCount>
				<DisplayName></DisplayName>
				<Description>阵法效率额外提高</Description>
				<SuitType>AddZhenProperty</SuitType>
				<TypeExtra>ReduceCostAddv</TypeExtra>
				<fParam1>36</fParam1>
			</li>
            <!-- The method of adding a new skill is out of scope for this example
			<li>
				<RequireCount>6</RequireCount>
				<DisplayName></DisplayName>
				<Description>New Skill: Weather Clearing</Description>
				<SuitType>AddSkill</SuitType>
				<SParam1>ZhenClearWeather</SParam1>
			</li>
            -->
		</SuitEffect>
	</Def>
</List></ZhenSuitDefs>
```

And the manual to add it, under Settings\Esoterica\Esoterica_ACS_M_EX_06.xml

```xml
<Esotericas><List>
    <Esoterica Name="ACS_M_EX_EsotericaZhenFa_6">
		<DisplayName>Formations: Example 06</DisplayName>
		<StarLevel>1</StarLevel>
		<Difficulty>1</Difficulty>
		<Desc>This is the description</Desc>
		<EffectDesc>This is the effect, formated.\nUnlocks Formation Diagram: \nWeather Clearing Formation<</EffectDesc>
		<GLevel>Qi</GLevel>
		<Element>None</Element>
		<ZhenShapes>
			<li Name="Weather Clearing Formation">
			<ShapeInfo>10|9|0|ACS_M_EX_06_weather_0|10|10|2|ACS_M_EX_06_weather_1|11|10|3|ACS_M_EX_06_weather_2|11|9|5|ACS_M_EX_06_weather_3|9|8|0|ACS_M_EX_06_weather_4|9|9|1|ACS_M_EX_06_weather_5</ShapeInfo>
			<Descript>A formation focusing on clearing the weather, improving cultivation.</Descript>
			</li>
		</ZhenShapes>
</List></Esotericas>
```