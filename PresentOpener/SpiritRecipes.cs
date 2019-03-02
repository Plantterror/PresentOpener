using Terraria.ModLoader;
using Terraria.ID;

namespace PresentOpener
{
    public class SpiritRecipes 
    {
        public static void AddRecipes(Mod mod)
        {
            Mod SpiritMod = ModLoader.GetMod("SpiritMod");

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 99);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "MaskHulk");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 2);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "Apple");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 4);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "Candy");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 4);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "HealthCandy");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 4);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "ManaCandy");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 4);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "Taffy");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 4);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "ChocolateBar");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 4);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "MysteryCandy");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 4);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "Lollipop");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 40);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "GoldCandy");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 40);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "MaskIggy");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 40);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "MaskSvante");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 40);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "MaskLeemyy");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 40);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "MaskSchmo");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 40);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "MaskLordCake");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 40);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "MaskYuyutsu");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 40);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "MaskVladimier");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 40);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "MaskGraydee");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 40);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "MaskBlaze");
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoodieBag, 40);
            recipe.AddTile(mod, "GoodieProcessor");
            recipe.SetResult(SpiritMod, "MaskKachow");
            recipe.AddRecipe();
        }
    }
}
