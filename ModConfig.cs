using Newtonsoft.Json;
using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace PresentOpener
{
	public class PresentOpenerConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Label("Present")]
		public PresentMenu presentmenu = new PresentMenu();
		[Label("Goodie Bag")]
		public GoodieMenu goodiemenu = new GoodieMenu();

		[SeparatePage]
		public class PresentMenu
		{
			[Header("Reset")]
			[JsonIgnore]
			[Label("Default Present Chances")]
			[Tooltip("Restores the original chances for vanilla items inside Presents.")]
			public bool DefaultPresentChance
			{
				get => SnowGlobeScale == 1f && CoalScale == 1f && WhistleScale == 1f && PresentRareItemScale == 1f && ToolboxScale == 1f && AntlersScale == 1f && HollyScale == 1f && VanityScale == 1f && FoodScale == 1f && EggnogScale == 1f && StarAniseScale == 1f && BlockScale == 1f;
				set
				{
					if (value)
					{
						SnowGlobeScale = 1f;
						CoalScale = 1f;
						WhistleScale = 1f;
						PresentRareItemScale = 1f;
						ToolboxScale = 1f;
						AntlersScale = 1f;
						HollyScale = 1f;
						VanityScale = 1f;
						FoodScale = 1f;
						EggnogScale = 1f;
						StarAniseScale = 1f;
						BlockScale = 1f;
					}
				}
			}
			[Header("Configurable Category Scales")]
			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Snowglobe Chance Scale")]
			[ReloadRequired]
			public float SnowGlobeScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Coal Chance Scale")]
			[ReloadRequired]
			public float CoalScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Dog Whistle Scale")]
			[ReloadRequired]
			public float WhistleScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Rare Items Scale")]
			[Tooltip("Includes Red Ryder, Candy Tools, Fruitcake Chakram, and Hand Warmer.")]
			[ReloadRequired]
			public float PresentRareItemScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Toolbox Scale")]
			[ReloadRequired]
			public float ToolboxScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Reindeer Antlers Scale")]
			[ReloadRequired]
			public float AntlersScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Holly Scale")]
			[ReloadRequired]
			public float HollyScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Vanity clothes Scale")]
			[ReloadRequired]
			public float VanityScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Food Scale")]
			[ReloadRequired]
			public float FoodScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Eggnog Scale")]
			[ReloadRequired]
			public float EggnogScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Star Anise Scale")]
			[ReloadRequired]
			public float StarAniseScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Block Scale")]
			[ReloadRequired]
			public float BlockScale { get; set; }
		}

		[SeparatePage]
		public class GoodieMenu
		{
			[Header("Reset")]
			[JsonIgnore]
			[Label("Default Goodie Bag Chances")]
			[Tooltip("Restores the original chances for vanilla items inside Goodie Bags.")]
			[ReloadRequired]
			public bool DefaultGoodieChance
			{
				get => GoodieRareItemScale == 1f && RottenEggScale == 1f && PaintingScale == 1f && CostumeScale == 1f;
				set
				{
					if (value)
					{
						GoodieRareItemScale = 1f;
						RottenEggScale = 1f;
						PaintingScale = 1f;
						CostumeScale = 1f;
					}
				}
			}

			[Header("Configurable Category Scales")]
			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Rare Items Scale")]
			[Tooltip("Includes Unluckly Yarn and Bat Hook.")]
			[ReloadRequired]
			public float GoodieRareItemScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Rotten Egg Scale")]
			[ReloadRequired]
			public float RottenEggScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Painting Scale")]
			[ReloadRequired]
			public float PaintingScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Costume Scale")]
			[ReloadRequired]
			public float CostumeScale { get; set; }
		}
	}
}
