using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PresentOpener
{
    public class PresentOpener : Mod //Self explanitory.
    {
        public override void AddRecipeGroups() //Recipe groups for Ice Queen and Pumpking weapon drops, respectively.
        {
            RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Ice Queen Drop", new int[] //Lang.misc is outdated, but it shouldn't affect mod building.
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

        public override void AddRecipes() //Recipes are sorted into categories because I do not want 75+ recipes clogging this code.
        {
            ChristmasRecipes.AddRecipes(this);
            HalloweenRecipes.AddRecipes(this);
            
            ModRecipe recipe = new ModRecipe(this); //Making Presents and Goodie Bags
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.SoulofLight, 3);
            recipe.AddIngredient(ItemID.LightShard);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.Present);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.SoulofNight, 3);
            recipe.AddIngredient(ItemID.DarkShard);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.GoodieBag);
            recipe.AddRecipe();

            Mod ThoriumMod = ModLoader.GetMod("ThoriumMod"); //Thorium support for their Mistletoe item, located in the present.
            if (ThoriumMod != null)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Present, 20);
                recipe.AddTile(this, "PresentProcessor");
                recipe.SetResult(ThoriumMod, "Mistletoe");
                recipe.AddRecipe();
            }
            Mod SpiritMod = ModLoader.GetMod("SpiritMod"); //Spirit support for all their stuff inside goodie bags. It's possible that they are no longer working on a 0.11 release so I might remove.
            if (SpiritMod != null)
            {
                SpiritRecipes.AddRecipes(this);
            }
        }
    }
}