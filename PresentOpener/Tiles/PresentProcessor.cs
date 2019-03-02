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

        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY) //Here's a Tip: DON'T MESS WITH THIS UNLESS YOU KNOW WHAT YOU'RE DOING. It took me 2 days just to get the right settings.
        {
            Item.NewItem(X: i * 16, Y: j * 16, Width: 60, Height: 40, Type: mod.ItemType("PresentProcessor"));
        }
    }
}