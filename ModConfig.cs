using Newtonsoft.Json;
using System.ComponentModel;
using Terraria;
using Terraria.ModLoader.Config;

namespace PresentOpener
{

	public class PresentOpenerConfig : ModConfig
	{
		public override bool Autoload(ref string name) //Autoloading config with a name
		{
			name = "PresentOpener Config";
			return true;
		}
		public override ConfigScope Mode => ConfigScope.ServerSide; //Server sided config.

		[Label("Present")] //This is how you make a folder, essentially it's just a separate class.
		public PresentMenu presentmenu = new PresentMenu();
		[Label("Goodie Bag")]
		public GoodieMenu goodiemenu = new GoodieMenu();
		[Label("Modded Items")]
		public ModdedMenu moddedmenu = new ModdedMenu();

		[SeparatePage] //To force the class into a new page, making the folder.
		public class PresentMenu
		{
			[Header("Reset")]
			[Label("Disable Adjusted Scales")]
			[DefaultValue(false)]
			public bool DisablePresentConfig { get; set; }

			[Header("Configurable Category Scales")]
			[Range(0.25f, 4f)]
			[Label("Snowglobe Chance Scale")]
			public float SnowGlobeScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Label("Coal Chance Scale")]
			public float CoalScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Label("Dog Whistle Scale")]
			public float WhistleScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Label("Rare Items Scale")]
			[Tooltip("Includes Red Ryder, Candy Tools, Fruitcake Chakram, and Hand Warmer.")]
			public float PresentRareItemScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Label("Toolbox Scale")]
			public float ToolboxScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Label("Reindeer Antlers Scale")]
			public float AntlersScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Label("Holly Scale")]
			public float HollyScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Label("Vanity clothes Scale")]
			public float VanityScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Label("Food Scale")]
			public float FoodScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Label("Eggnog Scale")]
			public float EggnogScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Label("Star Anise Scale")]
			public float StarAniseScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Label("Block Scale")]
			public float BlockScale { get; set; } = 1f;
		}

		[SeparatePage]
		public class GoodieMenu
		{
			[Header("Reset")]
			[Label("Disable Adjusted Scales")]
			[DefaultValue(false)]
			public bool DisableGoodieConfig { get; set; }

			[Header("Configurable Category Scales")]
			[Range(0.25f, 4f)]
			[Label("Rare Items Scale")]
			[Tooltip("Includes Unluckly Yarn and Bat Hook.")]
			public float GoodieRareItemScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Label("Rotten Egg Scale")]
			public float RottenEggScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Label("Painting Scale")]
			public float PaintingScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Label("Costume Scale")]
			public float CostumeScale { get; set; } = 1f;
		}
		[SeparatePage]
		public class ModdedMenu
		{
			[Header("Reset")]
			[Label("Disable Modded Configs")]
			public bool DisableModdedConfigs { get; set; }

			[Header("Thorium Mod")] 
			[Label("Mistletoe Scale")]
			[Range(0.25f, 4f)]
			public float ThoriumMistleScale { get; set; } = 1f;

			[Header("Spirit Mod")]
			[Label("Apple Scale")]
			[Tooltip("Includes Apple, Apple, Apple, and Apple.")]
			[Range(0.25f, 4f)]
			public float AppleScale { get; set; } = 1f;
			[Label("Candy Scale")]
			[Tooltip("Includes Normal, Health, Mana Candy, Taffy, Chocolate Bars, and Lolipops.")]
			[Range(0.25f, 4f)]
			public float SpiritCandyScale { get; set; } = 1f;
			[Label("Mystery Candy Scale")]
			[Range(0.25f, 4f)]
			public float MysteryCandyScale { get; set; } = 1f;
			[Label("Spirit Dev Mask Scale")]
			[Tooltip("Includes Iggy, Svante, Leemyy, Schmo, Cake Lord, Yuyutsu, Vladimier, Graydee, Blaze, Katchow masks.")]
			[Range(0.25f, 4f)]
			public float SpiritDevMaskScale { get; set; } = 1f;

		}
		public bool IsPlayerLocalServerOwner(Player player) //Little hacky
		{
			for (int plr = 0; plr < Main.maxPlayers; plr++)
			{
				System.Console.WriteLine(Netplay.Clients[plr].Socket.GetRemoteAddress());
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