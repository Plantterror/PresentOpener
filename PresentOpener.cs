using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace PresentOpener
{
	public class PresentOpener : Mod
	{
		public static string GithubUserName => "Plantterror"; //These 2 lines are for ModHelpers Github intergration.
		public static string GithubProjectName => "PresentOpener";
		internal static PresentOpenerConfig Config;
		internal static PresentOpener Instance;
		public override void Unload() //Unloading ModRecipes and ModConfig
		{
			Config = null; 
			Instance = null;
		}
		public override void Load() //Loading ModRecipes and ModConfig
		{
			Config = new PresentOpenerConfig();
			Instance = new PresentOpener();
		}
	}
}