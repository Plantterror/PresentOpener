using Terraria.ID;
using Terraria.ModLoader;

namespace PresentOpener
{
    public class ChristmasRecipes //Notice how there's no ":" and/or anything else after it.
    {
        public static void AddRecipes(Mod mod)
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.GreenCandyCaneBlock, 50);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.CandyCaneBlock, 50);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.Coal);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 40);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.RedRyder);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 40);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.DogWhistle);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 20);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.CandyCaneHook);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 20);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.CandyCaneSword);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 20);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.CnadyCanePickaxe);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 30);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.Toolbox);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 12);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.ReindeerAntlers);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 6);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.Holly);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 12);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.SnowHat);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 12);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.UglySweater);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 8);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.Eggnog, 4);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 8);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.SugarCookie);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 8);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.GingerbreadCookie);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 8);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.ChristmasPudding);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.PineTreeBlock, 50);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.StarAnise, 30);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.ParkaCoat);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.ParkaHood);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.ParkaPants);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.TreeMask);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.TreeShirt);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.TreeTrunks);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.MrsClauseHat);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.MrsClauseShirt);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.MrsClauseHeels);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 20);
            recipe.AddTile(mod, "PresentProcessor");
            recipe.SetResult(ItemID.SnowGlobe);
            recipe.AddRecipe();
        }
    }
}
