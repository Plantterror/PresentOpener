using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;
using Terraria.UI.Chat;

namespace PresentOpener.UI
{
    internal class PresentProcessUI : UIState
    {
        private VanillaItemSlotWrapper _vanillaItemSlot;
        public UIPanel PresentPanel;
        public static bool Visible;

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (!Main.playerInventory)
            {
                Visible = false;
            }
        }
        public override void OnInitialize()
        {
            PresentPanel = new UIPanel();
            PresentPanel.SetPadding(0);
            PresentPanel.Left.Set(350f, 0f);
            PresentPanel.Top.Set(50f, 0f);
            PresentPanel.Width.Set(200f, 0f);
            PresentPanel.Height.Set(50f, 0f);
            PresentPanel.BackgroundColor = new Color(73, 94, 171);

            _vanillaItemSlot = new VanillaItemSlotWrapper(ItemSlot.Context.BankItem, 0.85f)
            {
                Left = { Pixels = 30 },
                Top = { Pixels = 300 },
                ValidItemFunc = item => item.IsAir || (!item.IsAir && item.Name == "Present")
            };
            Append(_vanillaItemSlot);
        }
        public override void OnDeactivate()
        {
            base.OnDeactivate();
            if (!_vanillaItemSlot.Item.IsAir)
            {
                Main.LocalPlayer.QuickSpawnClonedItem(_vanillaItemSlot.Item, _vanillaItemSlot.Item.stack);
                _vanillaItemSlot.Item.TurnToAir();
            }
        }
        protected override void DrawSelf(SpriteBatch spriteBatch)
        {
            base.DrawSelf(spriteBatch);
            Main.craftingHide = true;
            const int slotX = 30;
            const int slotY = 300;
            if (_vanillaItemSlot.Item.IsAir)
            {
                string message = "Place a present here to unwrap";
                ChatManager.DrawColorCodedStringWithShadow(Main.spriteBatch, Main.fontMouseText, message, new Vector2(slotX + 50, slotY), new Color(Main.mouseTextColor, Main.mouseTextColor, Main.mouseTextColor, Main.mouseTextColor), 0f, Vector2.Zero, Vector2.One, -1f, 2f);
            }
            else
            {
                
            }
        }
    }
}