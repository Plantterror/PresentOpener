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
		internal static RecipeBuilder Recipes;
		internal static PresentOpener Instance;
		public override void Unload() //Unloading ModRecipes and ModConfig
		{
			Recipes = null;
			Config = null;
			Instance = null;
		}
		public override void Load() //Loading ModRecipes and ModConfig
		{
			Config = new PresentOpenerConfig();
			Recipes = new RecipeBuilder();
			Instance = new PresentOpener();
		}
		public override void AddRecipeGroups() //Recipe groups for Ice Queen and Pumpking weapon drops, respectively. Also Added an Evil Hardmode Crafting Ingredient group.
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Hardmode Material", new int[]
			{
					ItemID.CursedFlame,
					ItemID.Ichor
			});
			RecipeGroup.RegisterGroup("EvilHardmode", group);
		}

		public override void AddRecipes() //Recipes are moved to the RecipeBuilder, since having all 75+ recipes here would be chaos.
		{
			Recipes.LoadRecipes(this);
		}
	}
}