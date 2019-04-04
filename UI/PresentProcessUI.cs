using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace PresentOpener.UI
{
    internal class PresentProcessUI : UIState
    {
        private VanillaItemSlotWrapper _vanillaItemSlot;
        private VanillaItemSlotWrapper _vanillaResultSlot;
        public UIPanel PresentPanel;
        public UIText PresentText;

        public override void Update(GameTime gameTime)
        {
            if (!Main.playerInventory)
            {
                PresentOpener.Instance.PresentProcessInterface.SetState(null);
            }
            if (!_vanillaItemSlot.Item.IsAir)
            {
                throw new NotImplementedException();
            }
        }
        public override void OnInitialize()
        {
            PresentPanel = new UIPanel();
            PresentPanel.SetPadding(0);
            PresentPanel.Left.Set(25f, 0f);
            PresentPanel.Top.Set(290f, 0f);
            PresentPanel.Width.Set(370f, 0f);
            PresentPanel.Height.Set(70f, 0f);
            PresentPanel.BackgroundColor = new Color(73, 94, 171);
            Append(PresentPanel);

            _vanillaItemSlot = new VanillaItemSlotWrapper(ItemSlot.Context.BankItem, 0.85f)
            {
                Left = { Pixels = 30 },
                Top = { Pixels = 300 },
                ValidItemFunc = item => item.IsAir || (!item.IsAir && item.Name == "Present")
            };
            Append(_vanillaItemSlot);

            _vanillaResultSlot = new VanillaItemSlotWrapper()
            {
                Left = { Pixels = 330 },
                Top = { Pixels = 300 },
                ValidItemFunc = Item => false
            };
            Append(_vanillaResultSlot);

            PresentText = new UIText("Place a Present here to unwrap", 0.85f, false);
            PresentText.Top.Set(270f, 0f);
            PresentText.Left.Set(90f, 0f);
            Append(PresentText);
            
        }
        public override void OnDeactivate()
        {
            if (!_vanillaItemSlot.Item.IsAir)
            {
                Main.LocalPlayer.QuickSpawnClonedItem(_vanillaItemSlot.Item, _vanillaItemSlot.Item.stack);
                _vanillaItemSlot.Item.TurnToAir();
            }
        }
    }
}