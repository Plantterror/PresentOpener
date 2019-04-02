using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PresentOpener.UI;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace PresentOpener.Tiles //This is in the folder Tiles, so we add the .Tiles to help autoload know what it's doing.
{
    public class PresentProcessor : ModTile
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
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(X: i * 16, Y: j * 16, Width: 60, Height: 40, Type: mod.ItemType("PresentProcessor"));
        }
        public override void RightClick(int i, int j)
        {
            base.RightClick(i, j);
            Player player = Main.LocalPlayer;
            Tile tile = Main.tile[i, j];
            Main.mouseRightRelease = false;
            OpenUI();
        }
        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            Tile tile = Main.tile[i, j];
            int left = i;
            int top = j;
            if (tile.frameX % 36 != 0)
            {
                left--;
            }
            if (tile.frameY != 0)
            {
                top--;
            }
            player.noThrow = 2;
            player.showItemIcon2 = -1;
            player.showItemIcon = true;
        }
        public override bool HasSmartInteract()
        {
            return true;
        }

        public override void PostDraw(int i, int j, SpriteBatch spriteBatch)
        {
            if (PresentProcessUI.Visible)
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
            PresentProcessUI.Visible = open;
            Main.playerInventory = open;
        }
    }
}