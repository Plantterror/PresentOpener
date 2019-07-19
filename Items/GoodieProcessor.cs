using Terraria.ID;
using Terraria.ModLoader;

namespace PresentOpener.Items
{
    public class GoodieProcessor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Goodie Bag Processor");
            Tooltip.SetDefault("Used to open Goodie Bags.");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useAnimation = 15;
            item.useTime = 10;
            item.consumable = true;
            item.useTurn = true;
            item.autoReuse = true;
            item.createTile = mod.TileType("GoodieProcessor");
            item.width = 10;
            item.height = 8;
            item.maxStack = 99;
            item.value = 50000;
            item.rare = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 6);
            recipe.AddIngredient(ItemID.GoodieBag, 5);
            recipe.AddIngredient(ItemID.SoulofFright);
            recipe.AddIngredient(ItemID.AncientBattleArmorMaterial);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
