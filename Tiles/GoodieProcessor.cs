using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace PresentOpener.Tiles //Most of the comments about this are on the PresentProcessor version of this, as this is copypasted with word tweaks.
{
    public class GoodieProcessor : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
            TileObjectData.newTile.Width = 4;
            TileObjectData.newTile.CoordinateWidth = 18;
            TileObjectData.addTile(Type);
            Main.tileSolid[Type] = false;

        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY) 
        {
            Item.NewItem(X: i * 16, Y: j * 16, Width: 60, Height: 40, Type: mod.ItemType("GoodieProcessor"));
        }
    }
}