using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace PresentOpener.Globals
{
    public class OpenSeasonBag : GlobalItem //This class is solely to adjust the Present and Goodie bag chances to fit the config.
    {
        public override bool PreOpenVanillaBag(string context, Player player, int arg)
        {
            
            if (context == "present")
            {
                PresentOpenChances config = mod.GetConfig<PresentOpenChances>();

                if (Main.rand.Next(15 / (int)config.SnowGlobeScale) == 0 && Main.hardMode)
                {
                    player.QuickSpawnItem(ItemID.SnowGlobe);
                }
                else if (Main.rand.Next(30 / (int)config.CoalScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.Coal);
                }
                else if (Main.rand.Next(400 / (int)config.WhistleScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.DogWhistle);
                }
                else if (Main.rand.Next(150 / (int)config.RareItemScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.RedRyder);
                    player.QuickSpawnItem(ItemID.MusketBall, Main.rand.Next(30, 61));
                }
                else if (Main.rand.Next(150 / (int)config.RareItemScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.CandyCaneSword);
                }
                else if (Main.rand.Next(150 / (int)config.RareItemScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.CnadyCanePickaxe);
                }
                else if (Main.rand.Next(150 / (int)config.RareItemScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.CandyCaneHook);
                }
                else if (Main.rand.Next(150 / (int)config.RareItemScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.FruitcakeChakram);
                }
                else if (Main.rand.Next(150 / (int)config.RareItemScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.HandWarmer);
                }
                else if (Main.rand.Next(300 / (int)config.ToolboxScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.Toolbox);
                }
                else if (Main.rand.Next(40 / (int)config.AntlersScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.ReindeerAntlers);
                }
                else if (Main.rand.Next(10 / (int)config.HollyScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.Holly);
                }
                else if (Main.rand.Next(15 / (int)config.VanityScale) == 0)
                {
                    switch (Main.rand.Next(5))
                    {
                        case 0:
                            {
                                player.QuickSpawnItem(ItemID.MrsClauseHat);
                                player.QuickSpawnItem(ItemID.MrsClauseShirt);
                                player.QuickSpawnItem(ItemID.MrsClauseHeels);
                                break;
                            }
                        case 1:
                            {
                                player.QuickSpawnItem(ItemID.ParkaHood);
                                player.QuickSpawnItem(ItemID.ParkaCoat);
                                player.QuickSpawnItem(ItemID.ParkaPants);
                                break;
                            }
                        case 2:
                            {
                                player.QuickSpawnItem(ItemID.TreeMask);
                                player.QuickSpawnItem(ItemID.TreeShirt);
                                player.QuickSpawnItem(ItemID.TreeTrunks);
                                break;
                            }
                        case 3:
                            {
                                player.QuickSpawnItem(ItemID.SnowHat);
                                break;
                            }
                        case 4:
                            {
                                player.QuickSpawnItem(ItemID.UglySweater);
                                break;
                            }
                    }
                }
                else if (Main.rand.Next(7 / (int)config.FoodScale) == 0)
                {
                    switch (Main.rand.Next(2))
                    {
                        case 1:
                            {
                                player.QuickSpawnItem(ItemID.ChristmasPudding);
                                break;
                            }
                        case 2:
                            {
                                player.QuickSpawnItem(ItemID.SugarCookie);
                                break;
                            }
                        case 3:
                            {
                                player.QuickSpawnItem(ItemID.GingerbreadCookie);
                                break;
                            }
                    }
                }
                else if (Main.rand.Next(8 / (int)config.EggnogScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.Eggnog, Main.rand.Next(1, 4));
                }
                else if (Main.rand.Next(9 / (int)config.StarAniseScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.StarAnise, Main.rand.Next(20, 41));
                }
                else
                {
                    switch (Main.rand.Next(3))
                    {
                        case 0:
                            {
                                player.QuickSpawnItem(ItemID.PineTreeBlock, Main.rand.Next(20, 50));
                                break;
                            }
                        case 1:
                            {
                                player.QuickSpawnItem(ItemID.CandyCaneBlock, Main.rand.Next(20, 50));
                                break;
                            }
                        default:
                            {
                                player.QuickSpawnItem(ItemID.GreenCandyCaneBlock, Main.rand.Next(20, 50));
                                break;
                            }
                    }
                }
                return false;
            }
            if (context == "goodieBag")
            {
                GoodieBagOpenChances config = mod.GetConfig<GoodieBagOpenChances>();
                if (Main.rand.Next(150 / (int)config.RareItemScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.UnluckyYarn);
                }
                else if (Main.rand.Next(150 / (int)config.RareItemScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.BatHook);
                }
                else if (Main.rand.Next(4 / (int)config.RottenEggScale) == 0)
                {
                    player.QuickSpawnItem(ItemID.RottenEgg, Main.rand.Next(10, 41));
                }
                else if (Main.rand.Next(10 / (int)config.PaintingScale) == 0)
                {
                    switch (Main.rand.Next(4))
                    {
                        case 0:
                            {
                                player.QuickSpawnItem(ItemID.MorbidCuriosity);
                                break;
                            }
                        case 1:
                            {
                                player.QuickSpawnItem(ItemID.BitterHarvest);
                                break;
                            }
                        case 2:
                            {
                                player.QuickSpawnItem(ItemID.BloodMoonCountess);
                                break;
                            }
                        case 3:
                            {
                                player.QuickSpawnItem(ItemID.HallowsEve);
                                break;
                            }
                        case 4:
                            {
                                player.QuickSpawnItem(ItemID.JackingSkeletron);
                                break;
                            }
                    }
                }
                else
                {
                    switch (Main.rand.Next(19))
                    {
                        case 0:
                            {
                                player.QuickSpawnItem(ItemID.CatEars);
                                break;
                            }
                        case 1:
                            {
                                player.QuickSpawnItem(ItemID.CatMask);
                                player.QuickSpawnItem(ItemID.CatShirt);
                                player.QuickSpawnItem(ItemID.CatPants);
                                break;
                            }
                        case 2:
                            {
                                player.QuickSpawnItem(ItemID.CreeperMask);
                                player.QuickSpawnItem(ItemID.CreeperShirt);
                                player.QuickSpawnItem(ItemID.CreeperPants);
                                break;
                            }
                        case 3:
                            {
                                player.QuickSpawnItem(ItemID.PumpkinMask);
                                player.QuickSpawnItem(ItemID.PumpkinShirt);
                                player.QuickSpawnItem(ItemID.PumpkinPants);
                                break;
                            }
                        case 4:
                            {
                                player.QuickSpawnItem(ItemID.SpaceCreatureMask);
                                player.QuickSpawnItem(ItemID.SpaceCreatureShirt);
                                player.QuickSpawnItem(ItemID.SpaceCreaturePants);
                                break;
                            }
                        case 5:
                            {
                                player.QuickSpawnItem(ItemID.KarateTortoiseMask);
                                player.QuickSpawnItem(ItemID.KarateTortoiseShirt);
                                player.QuickSpawnItem(ItemID.KarateTortoisePants);
                                break;
                            }
                        case 6:
                            {
                                player.QuickSpawnItem(ItemID.FoxMask);
                                player.QuickSpawnItem(ItemID.FoxShirt);
                                player.QuickSpawnItem(ItemID.FoxPants);
                                break;
                            }
                        case 7:
                            {
                                player.QuickSpawnItem(ItemID.WitchHat);
                                player.QuickSpawnItem(ItemID.WitchDress);
                                player.QuickSpawnItem(ItemID.WitchBoots);
                                break;
                            }
                        case 8:
                            {
                                player.QuickSpawnItem(ItemID.VampireMask);
                                player.QuickSpawnItem(ItemID.VampireShirt);
                                player.QuickSpawnItem(ItemID.VampirePants);
                                break;
                            }
                        case 9:
                            {
                                player.QuickSpawnItem(ItemID.LeprechaunHat);
                                player.QuickSpawnItem(ItemID.LeprechaunShirt);
                                player.QuickSpawnItem(ItemID.LeprechaunPants);
                                break;
                            }
                        case 10:
                            {
                                player.QuickSpawnItem(ItemID.RobotMask);
                                player.QuickSpawnItem(ItemID.RobotShirt);
                                player.QuickSpawnItem(ItemID.RobotPants);
                                break;
                            }
                        case 11:
                            {
                                player.QuickSpawnItem(ItemID.PrincessHat);
                                player.QuickSpawnItem(ItemID.PrincessDressNew);
                                break;
                            }
                        case 12:
                            {
                                player.QuickSpawnItem(ItemID.TreasureHunterShirt);
                                player.QuickSpawnItem(ItemID.TreasureHunterPants);
                                break;
                            }
                        case 13:
                            {
                                player.QuickSpawnItem(ItemID.WolfMask);
                                player.QuickSpawnItem(ItemID.WolfShirt);
                                player.QuickSpawnItem(ItemID.WolfPants);
                                break;
                            }
                        case 14:
                            {
                                player.QuickSpawnItem(ItemID.UnicornMask);
                                player.QuickSpawnItem(ItemID.UnicornShirt);
                                player.QuickSpawnItem(ItemID.UnicornPants);
                                break;
                            }
                        case 15:
                            {
                                player.QuickSpawnItem(ItemID.ReaperHood);
                                player.QuickSpawnItem(ItemID.ReaperRobe);
                                break;
                            }
                        case 16:
                            {
                                player.QuickSpawnItem(ItemID.PixieShirt);
                                player.QuickSpawnItem(ItemID.PixiePants);
                                break;
                            }
                        case 17:
                            {
                                player.QuickSpawnItem(ItemID.BrideofFrankensteinMask);
                                player.QuickSpawnItem(ItemID.BrideofFrankensteinDress);
                                break;
                            }
                        case 18:
                            {
                                player.QuickSpawnItem(ItemID.GhostMask);
                                player.QuickSpawnItem(ItemID.GhostShirt);
                                break;
                            }
                    }
                }
                return false;
            }
            else return true;
        }
    }
}
