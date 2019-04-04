using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework.Graphics;
using PresentOpener.UI;
using Terraria.ID;

namespace PresentOpener.Tiles //This is in the folder Tiles, so we add the .Tiles to help autoload know what it's doing.
{
    public class PresentProcessorTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);   // So this is making the 4 by 3 style. Usually best to copy a style with the height you want. That way, you don't end up making the CoordinateHeight, which can be pretty lengthy. Meanwhile you can see here, CoordinateWidth is pretty simple.
            TileObjectData.newTile.Width = 4;
            TileObjectData.newTile.CoordinateWidth = 18;
            TileObjectData.addTile(Type);
            Main.tileSolid[Type] = false;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Present Processor");
            AddMapEntry(new Color(128, 128, 128), name);
            disableSmartCursor = true;
            animationFrameHeight = 54;

        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(X: i * 16, Y: j * 16, Width: 52, Height: 38, Type: mod.ItemType("PresentProcessorItem"));
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

        public override void RightClick(int i, int j)
        {
            base.RightClick(i, j);
            Player player = Main.LocalPlayer;
            Tile tile = Main.tile[i, j];
            Main.mouseRightRelease = false;
            OpenUI();

        }
        public override bool HasSmartInteract()
        {
            return true;
        }
        public override void PostDraw(int i, int j, SpriteBatch spriteBatch)
        {
            if (PresentOpener.Instance.PresentProcessInterface.CurrentState != null)
            {
                var PlayerPos = Main.LocalPlayer.position.ToTileCoordinates();

                if (PlayerPos.X - i > 7
                   || PlayerPos.X - i < -7
                   || PlayerPos.Y - j > 6
                   || PlayerPos.Y - j < -6)
                {
                    CloseUI();
                }
            }
        }

        public void OpenUI()
           => SetUI(true);

        public void CloseUI()
           => SetUI(false);

        private void SetUI(bool open)
        {
            if (open == true)
            {
                PresentOpener.Instance.PresentProcessInterface.SetState(new PresentProcessUI());
                Main.playerInventory = true;
            }
            else
            {
                PresentOpener.Instance.PresentProcessInterface.SetState(null);
            }
        }
    }
    internal class PresentProcessorItem : ModItem
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
            item.createTile = mod.TileType("PresentProcessorTile");
            item.width = 10;
            item.height = 8;
            item.maxStack = 99;
            item.value = 50000; //Worth 1 gold.
            item.rare = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GrayBrick, 20);
            recipe.AddIngredient(ItemID.Autohammer);
            recipe.AddRecipeGroup("IceQueenDrop"); //IceQueenDrop is our recipe group for Ice Queen weapon drops.
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

}