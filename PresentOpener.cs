using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace PresentOpener
{
    public class PresentOpener : Mod 
    {
        internal static RecipeBuilder Recipes = new RecipeBuilder();
        public override void Unload()
        {
            Recipes = null;
        }

        public override void AddRecipeGroups() //Recipe groups for Ice Queen and Pumpking weapon drops, respectively. Also Added an Evil Hardmode Crafting Ingredient group.
        {
            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Ice Queen Drop", new int[] //Lang.misc is outdated, but it shouldn't affect mod building.
            {
                    ItemID.BlizzardStaff,
                    ItemID.NorthPole,
                    ItemID.SnowmanCannon
            });
            RecipeGroup.RegisterGroup("IceQueenDrop", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Pumpking Drop", new int[]
            {
                    ItemID.TheHorsemansBlade,
                    ItemID.BatScepter,
                    ItemID.RavenStaff,
                    ItemID.CandyCornRifle,
                    ItemID.JackOLanternLauncher
            });
            RecipeGroup.RegisterGroup("PumpkingDrop", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Evil Hardmode Component", new int[]
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