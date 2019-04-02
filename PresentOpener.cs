using Microsoft.Xna.Framework;
using PresentOpener.UI;
using Terraria;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace PresentOpener
{
    public class PresentOpener : Mod //Self explanitory.

    {
        internal UserInterface PresentProcessInterface = new UserInterface();

        internal static PresentProcessUI PresentProcessUI;

        internal static PresentOpener Instance = new PresentOpener();

        public override void UpdateUI(GameTime gameTime)
        {
            base.UpdateUI(gameTime);
            if (Instance.PresentProcessInterface.CurrentState != null)
            {
                PresentProcessInterface.Update(gameTime);
            }
            PresentProcessUI.Update(gameTime);
        }

        public override void Load()
        {
            PresentProcessUI = new PresentProcessUI();
            PresentProcessUI.Activate();

            PresentProcessInterface = new UserInterface();
            PresentProcessInterface.SetState(new PresentProcessUI());

        }

        public override void AddRecipeGroups() //Recipe groups for Ice Queen and Pumpking weapon drops, respectively. Also Added an Evil Hardmode Crafting Ingredient group.
        {
            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("Any") + " Ice Queen Drop", new int[] //Lang.misc is outdated, but it shouldn't affect mod building. If you want good performance, use Language.GetTextValue.
            {
                    ItemID.BlizzardStaff,
                    ItemID.NorthPole,
                    ItemID.SnowmanCannon
            });
            RecipeGroup.RegisterGroup("IceQueenDrop", group);

            group = new RecipeGroup(() => Language.GetTextValue("Any") + " Pumpking Drop", new int[]
            {
                    ItemID.TheHorsemansBlade,
                    ItemID.BatScepter,
                    ItemID.RavenStaff,
                    ItemID.CandyCornRifle,
                    ItemID.JackOLanternLauncher
            });
            RecipeGroup.RegisterGroup("PumpkingDrop", group);

            group = new RecipeGroup(() => Language.GetTextValue("Any") + "Evil Hardmode Component", new int[]
            {
                    ItemID.CursedFlame,
                    ItemID.Ichor
            });
            RecipeGroup.RegisterGroup("EvilHardmode", group);
        }

        public override void AddRecipes() //Recipes are sorted into categories because I do not want 75+ recipes clogging this code.
        {
            ChristmasRecipes.AddRecipes(this);
            HalloweenRecipes.AddRecipes(this);
            
            ModRecipe recipe = new ModRecipe(this); //Making Presents and Goodie Bags
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddIngredient(ItemID.SoulofLight, 2);
            recipe.AddIngredient(ItemID.CrystalShard);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.Present);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddIngredient(ItemID.SoulofNight, 2);
            recipe.AddRecipeGroup("EvilHardmode");
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.GoodieBag);
            recipe.AddRecipe();

            Mod ThoriumMod = ModLoader.GetMod("ThoriumMod"); //Thorium support for their Mistletoe item, located in the present.
            if (ThoriumMod != null)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.Present, 15);
                recipe.AddTile(this, "PresentProcessor");
                recipe.SetResult(ThoriumMod, "Mistletoe");
                recipe.AddRecipe();
            }
        }
        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int inventoryIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Inventory"));
            if (inventoryIndex != -1)
            {
                layers.Insert(inventoryIndex, new LegacyGameInterfaceLayer(
                    "Present Processor: Present Processor UI",
                    delegate {
                        if (Instance.PresentProcessInterface.CurrentState != null)
                        {
                            PresentProcessInterface.Draw(Main.spriteBatch, new GameTime());
                        }
                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }
        }
    }
}