using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PresentOpener
{
    public class PresentOpener : Mod //Self explanitory.
    {
        public override void AddRecipeGroups() //Recipe groups for Ice Queen and Pumpking weapon drops, respectively.
        {
            RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Ice Queen Drop", new int[]
            {
                    ItemID.BlizzardStaff,
                    ItemID.NorthPole,
                    ItemID.SnowmanCannon
            });
            RecipeGroup.RegisterGroup("IceQueenDrop", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Pumpking Drop", new int[]
            {
                    ItemID.TheHorsemansBlade,
                    ItemID.BatScepter,
                    ItemID.RavenStaff,
                    ItemID.CandyCornRifle,
                    ItemID.JackOLanternLauncher
            });
            RecipeGroup.RegisterGroup("PumpkingDrop", group);
        }

        public override void AddRecipes() //Recipes are sorted into categories because I do not want 75 recipes clogging this code.
        {
            ChristmasRecipes.AddRecipes(this);
            HalloweenRecipes.AddRecipes(this);

            Mod ThoriumMod = ModLoader.GetMod("ThoriumMod"); //Thorium support for their Mistletoe item, located in the present.
            if (ThoriumMod != null)
            {
                ModRecipe recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Present, 20);
                recipe.AddTile(this, "PresentProcessor");
                recipe.SetResult(ThoriumMod, "Mistletoe");
                recipe.AddRecipe();
            }

            Mod SpiritMod = ModLoader.GetMod("SpiritMod"); //Spirit mod support for their dev kits and goodie bag candy. I heard they might not recieve a 0.11 update, so I'll probably remove this.
            if (SpiritMod != null)
            {
                SpiritRecipes.AddRecipes(this);
            }
        }
    }
}