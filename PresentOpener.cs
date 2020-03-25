using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace PresentOpener
{
	public class PresentOpener : Mod
	{
		public static string GithubUserName => "Plantterror"; //These 2 lines are for ModHelpers Github intergration, just in case.
		public static string GithubProjectName => "PresentOpener";
		internal static PresentOpenerConfig Config;
		internal static PresentOpener Instance;
		public override void Unload() //Unloading ModConfig and Instance
		{
			Config = null;
			Instance = null;
		}
		public override void Load() //Loading ModConfig and making an instance
		{
			Config = new PresentOpenerConfig();
			Instance = new PresentOpener();
		}
	}
}