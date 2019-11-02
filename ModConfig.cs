using Newtonsoft.Json;
using System.ComponentModel;
using log4net;
using Terraria;
using Terraria.Achievements;
using Terraria.Audio;
using Terraria.Chat;
using Terraria.Cinematics;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.ID;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Map;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.Modules;
using Terraria.Net;
using Terraria.ObjectData;
using Terraria.Server;
using Terraria.Social;
using Terraria.UI;
using Terraria.Utilities;
using Terraria.World;

namespace PresentOpener
{
	public class PresentOpenerConfig : ModConfig
	{
		public override bool Autoload(ref string name)
		{
			name = "PresentOpener Config";
			return true;
		}
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
			[Label("Disable Adjusted Scales")]
			public bool DisablePresentConfig { get; set; }

			[Header("Configurable Category Scales")]
			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Snowglobe Chance Scale")]

			public float SnowGlobeScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Coal Chance Scale")]

			public float CoalScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Dog Whistle Scale")]

			public float WhistleScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Rare Items Scale")]
			[Tooltip("Includes Red Ryder, Candy Tools, Fruitcake Chakram, and Hand Warmer.")]

			public float PresentRareItemScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Toolbox Scale")]

			public float ToolboxScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Reindeer Antlers Scale")]

			public float AntlersScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Holly Scale")]

			public float HollyScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Vanity clothes Scale")]

			public float VanityScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Food Scale")]

			public float FoodScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Eggnog Scale")]

			public float EggnogScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Star Anise Scale")]

			public float StarAniseScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Block Scale")]

			public float BlockScale { get; set; }
		}

		[SeparatePage]
		public class GoodieMenu
		{
			[Header("Reset")]
			[JsonIgnore]
			[Label("Default Goodie Bag Chances")]
			[Tooltip("Restores the original chances for vanilla items inside Goodie Bags.")]
			
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
			[Label("Disable Adjusted Scales")]
			public bool DisableGoodieConfig { get; set; }

			[Header("Configurable Category Scales")]
			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Rare Items Scale")]
			[Tooltip("Includes Unluckly Yarn and Bat Hook.")]

			public float GoodieRareItemScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Rotten Egg Scale")]

			public float RottenEggScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Painting Scale")]

			public float PaintingScale { get; set; }

			[DefaultValue(1f)]
			[Range(0.25f, 4f)]
			[Label("Costume Scale")]

			public float CostumeScale { get; set; }
		}
		public static bool IsPlayerLocalServerOwner(Player player) //Little hacky
		{
			for (int plr = 0; plr < Main.maxPlayers; plr++)
			{
				if (Netplay.Clients[plr].State == 10 && Main.player[plr] == player && Netplay.Clients[plr].Socket.GetRemoteAddress().IsLocalHost())
				{
					return true;
				}
			}
			return false;
		}
		public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
		{
			if (IsPlayerLocalServerOwner(Main.LocalPlayer))
			{
				return true;
			}
			else
			{
				message = "You are not the server host, and cannot change these settings.";
				return false;
			}
		}
	}
}