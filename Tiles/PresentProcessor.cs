using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;

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
            animationFrameHeight = 54;

        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(X: i * 16, Y: j * 16, Width: 52, Height: 38, Type: mod.ItemType("PresentProcessor"));
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
}