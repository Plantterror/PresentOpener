﻿using Terraria.ID;
using Terraria.ModLoader;

namespace PresentOpener.Items
{
    public class PresentProcessor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Present Processor");
            Tooltip.SetDefault("Used to open Presents.");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useAnimation = 15;
            item.useTime = 10;
            item.consumable = true;
            item.useTurn = true;
            item.autoReuse = true;
            item.createTile = mod.TileType("PresentProcessor");
            item.width = 10;
            item.height = 8;
            item.maxStack = 99;
            item.value = 50000; //Worth 1 gold.
            item.rare = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 6);
            recipe.AddIngredient(ItemID.Present, 5);
            recipe.AddIngredient(ItemID.SoulofMight);
            recipe.AddIngredient(ItemID.FrostCore);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
