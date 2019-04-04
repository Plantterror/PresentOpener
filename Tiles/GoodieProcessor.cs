using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace PresentOpener.Tiles //Most of the comments about this are on the PresentProcessor version of this, as this is copypasted with word tweaks.
{
    public class GoodieProcessorTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
            TileObjectData.newTile.Width = 4;
            TileObjectData.newTile.CoordinateWidth = 18;
            TileObjectData.addTile(Type);
            Main.tileSolid[Type] = false;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Goodie Bag Processor");
            AddMapEntry(new Color(128, 128, 128), name);
            disableSmartCursor = true;
            animationFrameHeight = 54;

        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY) 
        {
            Item.NewItem(X: i * 16, Y: j * 16, Width: 52, Height: 38, Type: mod.ItemType("GoodieProcessorItem"));
        }
        public override void AnimateIndividualTile(int type, int i, int j, ref int frameXOffset, ref int frameYOffset)
        {
            int uniqueAnimationFrame = Main.tileFrame[Type] + i;
            if (i % 2 == 0)
            {
                uniqueAnimationFrame += 3;
            }
            if (i % 3 == 0)
            {
                uniqueAnimationFrame += 3;
            }
            if (i % 4 == 0)
            {
                uniqueAnimationFrame += 3;
            }
            if (i % 5 == 0)
            {
                uniqueAnimationFrame += 3;
            }
            if (i % 6 == 0)
            {
                uniqueAnimationFrame += 3;
            }
            uniqueAnimationFrame = uniqueAnimationFrame % 6;
        }
        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            if (++frameCounter >= 9)
            {
                frameCounter = 0;
                frame = ++frame % 6;
            }
        }
    }
    internal class GoodieProcessorItem : ModItem
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
            item.createTile = mod.TileType("GoodieProcessorTile");
            item.width = 10;
            item.height = 8;
            item.maxStack = 99;
            item.value = 50000;
            item.rare = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GrayBrick, 20);
            recipe.AddIngredient(ItemID.Autohammer);
            recipe.AddRecipeGroup("PumpkingDrop"); //PumpkingDrop is a Recipe Group for the Pumpking Weapon drops.
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}