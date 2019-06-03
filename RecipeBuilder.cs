using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace PresentOpener
{
    public class RecipeBuilder
    {
        internal static RecipeBuilder Instance;
        public List<ProcessorItem> PresentItems { get; }
        public List<ProcessorItem> GoodieBagItems { get; }

        public RecipeBuilder()
        {
            Instance = this;
            PresentItems = new List<ProcessorItem>()
            {
                new ProcessorItem(ItemID.GreenCandyCaneBlock, 2, 50),
                new ProcessorItem(ItemID.CandyCaneBlock, 2, 50),
                new ProcessorItem(ItemID.Coal, 2),
                new ProcessorItem(ItemID.RedRyder, 40),
                new ProcessorItem(ItemID.DogWhistle, 40),
                new ProcessorItem(ItemID.CandyCaneHook, 20),
                new ProcessorItem(ItemID.CandyCaneSword, 20),
                new ProcessorItem(ItemID.CnadyCanePickaxe, 20),
                new ProcessorItem(ItemID.Toolbox, 20),
                new ProcessorItem(ItemID.ReindeerAntlers, 12),
                new ProcessorItem(ItemID.Holly, 10),
                new ProcessorItem(ItemID.SnowHat, 12),
                new ProcessorItem(ItemID.UglySweater, 12),
                new ProcessorItem(ItemID.Eggnog, 8, 2),
                new ProcessorItem(ItemID.SugarCookie, 8, 2),
                new ProcessorItem(ItemID.GingerbreadCookie, 8, 2),
                new ProcessorItem(ItemID.ChristmasPudding, 8, 2),
                new ProcessorItem(ItemID.PineTreeBlock, 2, 50),
                new ProcessorItem(ItemID.StarAnise, 4, 30),
                new ProcessorItem(ItemID.ParkaCoat, 4),
                new ProcessorItem(ItemID.ParkaHood, 4),
                new ProcessorItem(ItemID.ParkaPants, 4),
                new ProcessorItem(ItemID.TreeMask, 4),
                new ProcessorItem(ItemID.TreeShirt, 4),
                new ProcessorItem(ItemID.TreeTrunks, 4),
                new ProcessorItem(ItemID.MrsClauseHat, 4),
                new ProcessorItem(ItemID.MrsClauseShirt, 4),
                new ProcessorItem(ItemID.MrsClauseHeels, 4),
                new ProcessorItem(ItemID.SnowGlobe, 20)
            };

            GoodieBagItems = new List<ProcessorItem>()
            {
                new ProcessorItem(ItemID.BitterHarvest, 8),
                new ProcessorItem(ItemID.BloodMoonCountess, 8),
                new ProcessorItem(ItemID.HallowsEve, 8),
                new ProcessorItem(ItemID.MorbidCuriosity, 8),
                new ProcessorItem(ItemID.JackingSkeletron, 8),
                new ProcessorItem(ItemID.UnluckyYarn, 40),
                new ProcessorItem(ItemID.BatHook, 40),
                new ProcessorItem(ItemID.RottenEgg, 4, 40),
                new ProcessorItem(ItemID.CatEars, 4),
                new ProcessorItem(ItemID.CreeperMask, 4),
                new ProcessorItem(ItemID.CreeperShirt, 4),
                new ProcessorItem(ItemID.CreeperPants, 4),
                new ProcessorItem(ItemID.PumpkinMask, 4),
                new ProcessorItem(ItemID.PumpkinShirt, 4),
                new ProcessorItem(ItemID.PumpkinPants, 4),
                new ProcessorItem(ItemID.SpaceCreatureMask, 4),
                new ProcessorItem(ItemID.SpaceCreatureShirt, 4),
                new ProcessorItem(ItemID.SpaceCreaturePants, 4),
                new ProcessorItem(ItemID.CatMask, 4),
                new ProcessorItem(ItemID.CatShirt, 4),
                new ProcessorItem(ItemID.CatPants, 4),
                new ProcessorItem(ItemID.KarateTortoiseMask, 4),
                new ProcessorItem(ItemID.KarateTortoiseShirt, 4),
                new ProcessorItem(ItemID.KarateTortoisePants, 4),
                new ProcessorItem(ItemID.FoxMask, 4),
                new ProcessorItem(ItemID.FoxShirt, 4),
                new ProcessorItem(ItemID.FoxPants, 4),
                new ProcessorItem(ItemID.WitchHat, 4),
                new ProcessorItem(ItemID.WitchDress, 4),
                new ProcessorItem(ItemID.WitchBoots, 4),
                new ProcessorItem(ItemID.VampireMask, 4),
                new ProcessorItem(ItemID.VampireShirt, 4),
                new ProcessorItem(ItemID.VampirePants, 4),
                new ProcessorItem(ItemID.LeprechaunHat, 4),
                new ProcessorItem(ItemID.LeprechaunShirt, 4),
                new ProcessorItem(ItemID.LeprechaunPants, 4),
                new ProcessorItem(ItemID.RobotMask, 4),
                new ProcessorItem(ItemID.RobotShirt, 4),
                new ProcessorItem(ItemID.RobotPants, 4),
                new ProcessorItem(ItemID.PrincessHat, 4),
                new ProcessorItem(ItemID.PrincessDressNew, 4),
                new ProcessorItem(ItemID.TreasureHunterShirt, 4),
                new ProcessorItem(ItemID.TreasureHunterPants, 4),
                new ProcessorItem(ItemID.WolfMask, 4),
                new ProcessorItem(ItemID.WolfShirt, 4),
                new ProcessorItem(ItemID.WolfPants, 4),
                new ProcessorItem(ItemID.UnicornMask, 4),
                new ProcessorItem(ItemID.UnicornShirt, 4),
                new ProcessorItem(ItemID.UnicornPants, 4),
                new ProcessorItem(ItemID.ReaperHood, 4),
                new ProcessorItem(ItemID.ReaperRobe, 4),
                new ProcessorItem(ItemID.PixieShirt, 4),
                new ProcessorItem(ItemID.PixiePants, 4),
                new ProcessorItem(ItemID.BrideofFrankensteinMask, 4),
                new ProcessorItem(ItemID.BrideofFrankensteinDress, 4),
                new ProcessorItem(ItemID.GhostMask, 4),
                new ProcessorItem(ItemID.GhostShirt, 4)
            };
        }

        public void LoadRecipes(Mod mod)
        {
            // Add the present recipes
            foreach (var item in PresentItems)
            {
                var recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Present, item.CraftingQuantityRequired);
                recipe.AddTile(mod, "PresentProcessor");
                recipe.SetResult(item.ItemID, item.ItemQuantity);
                recipe.AddRecipe();
            }

            // Add the goodie bag recipes
            foreach (var item in GoodieBagItems)
            {
                var recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.GoodieBag, item.CraftingQuantityRequired);
                recipe.AddTile(mod, "GoodieProcessor");
                recipe.SetResult(item.ItemID, item.ItemQuantity);
                recipe.AddRecipe();
            }

            //Making Presents and Goodie Bags
            ModRecipe PresentRecipe = new ModRecipe(mod);
            PresentRecipe.AddIngredient(ItemID.Silk, 5);
            PresentRecipe.AddIngredient(ItemID.SoulofLight, 2);
            PresentRecipe.AddIngredient(ItemID.CrystalShard);
            PresentRecipe.AddTile(TileID.Loom);
            PresentRecipe.SetResult(ItemID.Present);
            PresentRecipe.AddRecipe();

            ModRecipe GoodieBagRecipe = new ModRecipe(mod);
            GoodieBagRecipe.AddIngredient(ItemID.Silk, 5);
            GoodieBagRecipe.AddIngredient(ItemID.SoulofNight, 2);
            GoodieBagRecipe.AddRecipeGroup("EvilHardmode");
            GoodieBagRecipe.AddTile(TileID.Loom);
            GoodieBagRecipe.SetResult(ItemID.GoodieBag);
            GoodieBagRecipe.AddRecipe();

            //Modded content will go here. Contact me or commit if there's other modded items that spawn from presents and goodie bags. Current mods supported: Thorium, Spirit
            Mod ThoriumLoaded = ModLoader.GetMod("ThoriumMod");
            if (ThoriumLoaded != null)
            {
                ModRecipe thoriumrecipe = new ModRecipe(mod);
                thoriumrecipe.AddIngredient(ItemID.Present, 15);
                thoriumrecipe.AddTile(mod, "PresentProcessor");
                thoriumrecipe.SetResult(ThoriumLoaded.ItemType("Mistletoe"));
                thoriumrecipe.AddRecipe();
            }
        }
    }

    public class ProcessorItem
    {
        public int ItemID { get; }
        public int CraftingQuantityRequired { get; }
        public int ItemQuantity { get; }
    
        public ProcessorItem(int itemID, int craftingQuantityRequired, int itemQuantity = 1)
        {
            ItemID = itemID;
            CraftingQuantityRequired = craftingQuantityRequired;
            ItemQuantity = itemQuantity;
        }
    }
}