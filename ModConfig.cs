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
			name = Language.GetTextValue("Mods.PresentOpener.common.ConfigName");
			return true;
		}
		public override ConfigScope Mode => ConfigScope.ServerSide; //Server sided config.

		[Label(Language.GetTextValue("Mods.PresentOpener.common.PresentMenuConfig"))] //This is how you make a folder, essentially it's just a separate class.
		public PresentMenu presentmenu = new PresentMenu();
		[Label(Language.GetTextValue("Mods.PresentOpener.common.GoodieBagMenuConfig"))]
		public GoodieMenu goodiemenu = new GoodieMenu();
		[Label(Language.GetTextValue("Mods.PresentOpener.common.ModdedItemsMenuConfig"))]
		public ModdedMenu moddedmenu = new ModdedMenu();

		[SeparatePage] //To force the class into a new page, making the folder.
		public class PresentMenu
		{
			[Header(Language.GetTextValue("common.ResetScalesConfigHeader"))]
			[Label(Language.GetTextValue("common.ResetScalesConfigLabel"))]
			[DefaultValue(false)]
			public bool DisablePresentConfig { get; set; }

			[Header(Language.GetTextValue("common.ConfigurableCategoryConfigHeader"))]
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.SnowGlobeChanceConfig"))]
			public float SnowGlobeScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.CoalChanceConfig"))]
			public float CoalScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.DogWhistleChanceScale"))]
			public float WhistleScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.RareItemsScaleConfigHeader"))]
			[Tooltip(Language.GetTextValue("common.RareItemsScaleConfigTooltipPresentMenu"))]
			public float PresentRareItemScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.ToolboxChanceScale"))]
			public float ToolboxScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.ReinderAntlersChanceScale"))]
			public float AntlersScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.HollyChanceScale"))]
			public float HollyScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.VanityClothesChanceScale"))]
			public float VanityScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.FoodChanceScale"))]
			public float FoodScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.EggnogChanceScale"))]
			public float EggnogScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.StarAniseChanceScale"))]
			public float StarAniseScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.BlockChanceScale"))]
			public float BlockScale { get; set; } = 1f;
		}

		[SeparatePage]
		public class GoodieMenu
		{
			[Header(Language.GetTextValue("common.ResetScalesConfigHeader"))]
			[Label(Language.GetTextValue("common.ResetScalesConfigLabel"))]
			[DefaultValue(false)]
			public bool DisableGoodieConfig { get; set; }

			[Header(Language.GetTextValue("common.ConfigurableCategoryConfigHeader"))]
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.RareItemsScaleConfigHeader"))]
			[Tooltip(Language.GetTextValue("common.RareItemsScaleConfigTooltipGoodieMenu"))]
			public float GoodieRareItemScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.RottenEggChanceScale"))]
			public float RottenEggScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.PaintingChanceScale"))]
			public float PaintingScale { get; set; } = 1f;
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			[Label(Language.GetTextValue("common.CostumeChanceScale"))]
			public float CostumeScale { get; set; } = 1f;
		}
		[SeparatePage]
		public class ModdedMenu
		{
			[Header(Language.GetTextValue("common.ResetScalesConfigHeader"))]
			[Label(Language.GetTextValue("common.ResetScalesConfigLabel"))]
			public bool DisableModdedConfigs { get; set; }

			[Header(Language.GetTextValue("common.ModdedMenuThoriumHeader"))] 
			[Label(Language.GetTextValue("common.MistletoeChanceScale"))]
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			public float ThoriumMistleScale { get; set; } = 1f;

			[Header(Language.GetTextValue("common.ModdedMenuSpiritHeader"))]
			[Label(Language.GetTextValue("common.AppleChanceScale"))]
			[Tooltip(Language.GetTextValue("common.AppleChanceScaleTooltip"))]
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			public float AppleScale { get; set; } = 1f;
			[Label(Language.GetTextValue("common.CandyChanceScale"))]
			[Tooltip(Language.GetTextValue("common.CandyChanceScaleTooltip"))]
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			public float SpiritCandyScale { get; set; } = 1f;
			[Label(Language.GetTextValue("common.MysteryCandyChanceScale"))]
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			public float MysteryCandyScale { get; set; } = 1f;
			[Label(Language.GetTextValue("common.SpiritDevMaskChanceScale"))]
			[Tooltip(Language.GetTextValue("common.SpiritDevMaskChanceScale"))]
			[Range(0.25f, 4f)]
			[Increment(0.25f)]
			public float SpiritDevMaskScale { get; set; } = 1f;

		}
		public bool IsPlayerLocalServerOwner(Player player) //coming back to this code after 3 months and I still can't follow it but it works I guess
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
				message = Language.GetTextValue("common.NotServerHostError");
				return false;
			}
		}
	}
}