using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace PresentOpener
{
    public class PresentOpener : Mod 
    {
        internal static RecipeBuilder Recipes;
        public override void Unload()
        {
            Recipes = null;
        }
        public override void Load()
        {
            Recipes = new RecipeBuilder();
        }
        public override void AddRecipeGroups() //Recipe groups for Ice Queen and Pumpking weapon drops, respectively. Also Added an Evil Hardmode Crafting Ingredient group.
        {
            RecipeGroup  group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Hardmode Evil Material", new int[]
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