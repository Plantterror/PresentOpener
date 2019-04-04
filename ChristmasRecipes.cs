using Terraria.ID;
using Terraria.ModLoader;

namespace PresentOpener
{
    public class ChristmasRecipes //Notice how there's no ":" and/or anything else after it.
    {
        public static void AddRecipes(Mod mod)
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 2);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.GreenCandyCaneBlock, 50);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 2);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.CandyCaneBlock, 50);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 2);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.Coal);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 40);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.RedRyder);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 40);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.DogWhistle);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 20);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.CandyCaneHook);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 20);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.CandyCaneSword);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 20);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.CnadyCanePickaxe);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 20);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.Toolbox);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 12);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.ReindeerAntlers);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 10);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.Holly);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 12);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.SnowHat);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 12);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.UglySweater);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 8);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.Eggnog, 2);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 8);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.SugarCookie, 2);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 8);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.GingerbreadCookie, 2);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 8);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.ChristmasPudding, 2);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 2);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.PineTreeBlock, 50);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.StarAnise, 30);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.ParkaCoat);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.ParkaHood);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.ParkaPants);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.TreeMask);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.TreeShirt);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.TreeTrunks);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.MrsClauseHat);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.MrsClauseShirt);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 4);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.MrsClauseHeels);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 20);
            recipe.AddTile(mod, "PresentProcessorTile");
            recipe.SetResult(ItemID.SnowGlobe);
            recipe.AddRecipe();

            Mod ThoriumMod = ModLoader.GetMod("ThoriumMod"); //Thorium support for their Mistletoe item, located in the present.
            if (ThoriumMod != null)
            {
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Present, 15);
                recipe.AddTile(mod, "PresentProcessorTile");
                recipe.SetResult(ThoriumMod, "Mistletoe");
                recipe.AddRecipe();
            }
        }
    }
}
