﻿using Microsoft.Xna.Framework;
using Terraria.UI;
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
            Main.playerInventory = true;
            PresentOpener.Instance.PresentProcessInterface.SetState(PresentOpener.PresentProcessUI);

        }
        public override bool HasSmartInteract()
        {
            return true;
        }
    }
}