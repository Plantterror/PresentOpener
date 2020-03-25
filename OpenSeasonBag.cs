﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using static Terraria.ModLoader.ModContent;

namespace PresentOpener
{
	public class OpenSeasonBag : GlobalItem //This class is solely to adjust the Present and Goodie bag chances to fit the config.
	{
		public override bool PreOpenVanillaBag(string context, Player player, int arg)
		{
			switch (context)
			{
				case "present":
					{
						PresentOpenerConfig config = new PresentOpenerConfig();
						if (!config.presentmenu.DisablePresentConfig)
						{

							WeightedRandom<int> presentrandom = new WeightedRandom<int>(); //This is a form of randomness made by Terraria, useful for avoiding long If/Else chains like I have previously done.

							if (Main.hardMode)
							{
								presentrandom.Add(ItemID.SnowGlobe, 1f / 5f * config.presentmenu.SnowGlobeScale);
							}
							presentrandom.Add(ItemID.Coal, 1f / 30f * config.presentmenu.CoalScale);
							presentrandom.Add(ItemID.DogWhistle, 1f / 419f * config.presentmenu.WhistleScale);
							presentrandom.Add(ItemID.RedRyder, 1f / 156f * config.presentmenu.PresentRareItemScale);
							presentrandom.Add(ItemID.CandyCaneSword, 1f / 156f * config.presentmenu.PresentRareItemScale);
							presentrandom.Add(ItemID.CnadyCanePickaxe, 1f / 159f * config.presentmenu.PresentRareItemScale);
							presentrandom.Add(ItemID.CandyCaneHook, 1f / 159f * config.presentmenu.PresentRareItemScale);
							presentrandom.Add(ItemID.FruitcakeChakram, 1f / 160f * config.presentmenu.PresentRareItemScale);
							presentrandom.Add(ItemID.HandWarmer, 1f / 161f * config.presentmenu.PresentRareItemScale);
							presentrandom.Add(ItemID.Toolbox, 1f / 323f * config.presentmenu.ToolboxScale);
							presentrandom.Add(ItemID.ReindeerAntlers, 1f / 43f * config.presentmenu.AntlersScale);
							presentrandom.Add(ItemID.Holly, 1f / 11f * config.presentmenu.HollyScale);
							presentrandom.Add(ItemID.MrsClauseHat, 1f / 92f * config.presentmenu.VanityScale);
							presentrandom.Add(ItemID.ParkaHood, 1f / 92f * config.presentmenu.VanityScale);
							presentrandom.Add(ItemID.TreeMask, 1f / 92f * config.presentmenu.VanityScale);
							presentrandom.Add(ItemID.SnowHat, 1f / 92f * config.presentmenu.VanityScale);
							presentrandom.Add(ItemID.UglySweater, 1f / 92f * config.presentmenu.VanityScale);
							presentrandom.Add(ItemID.ChristmasPudding, 1f / 28f * config.presentmenu.FoodScale);
							presentrandom.Add(ItemID.SugarCookie, 1f / 28f * config.presentmenu.FoodScale);
							presentrandom.Add(ItemID.GingerbreadCookie, 1f / 28f * config.presentmenu.FoodScale);
							presentrandom.Add(ItemID.Eggnog, 1f / 12f * config.presentmenu.EggnogScale);
							presentrandom.Add(ItemID.StarAnise, 1f / 16f * config.presentmenu.StarAniseScale);
							presentrandom.Add(ItemID.PineTreeBlock, 1f / 6f * config.presentmenu.BlockScale);
							presentrandom.Add(ItemID.CandyCaneBlock, 1f / 6f * config.presentmenu.BlockScale);
							presentrandom.Add(ItemID.GreenCandyCaneBlock, 1f / 6f * config.presentmenu.BlockScale);
							Mod ThoriumMod = ModLoader.GetMod("ThoriumMod");
							if (ThoriumMod != null && config.moddedmenu.DisableModdedConfigs == false)
							{
								presentrandom.Add(ThoriumMod.ItemType("Mistletoe"), 1f / 10f * config.moddedmenu.ThoriumMistleScale);
							}

							if (presentrandom != null)
							{

								switch (presentrandom)
								{
									case ItemID.RedRyder:
										player.QuickSpawnItem(presentrandom);
										player.QuickSpawnItem(ItemID.MusketBall, Main.rand.Next(30, 61));
										break;
									case ItemID.MrsClauseHat:
										player.QuickSpawnItem(ItemID.MrsClauseHat);
										player.QuickSpawnItem(ItemID.MrsClauseShirt);
										player.QuickSpawnItem(ItemID.MrsClauseHeels);
										break;
									case ItemID.ParkaHood:
										player.QuickSpawnItem(ItemID.ParkaHood);
										player.QuickSpawnItem(ItemID.ParkaCoat);
										player.QuickSpawnItem(ItemID.ParkaPants);
										break;
									case ItemID.TreeMask:
										player.QuickSpawnItem(ItemID.TreeMask);
										player.QuickSpawnItem(ItemID.TreeShirt);
										player.QuickSpawnItem(ItemID.TreeTrunks);
										break;
									case ItemID.Eggnog:
										player.QuickSpawnItem(ItemID.Eggnog, Main.rand.Next(1, 4));
										break;
									case ItemID.StarAnise:
										player.QuickSpawnItem(ItemID.StarAnise, Main.rand.Next(20, 41));
										break;
									case ItemID.PineTreeBlock:
										player.QuickSpawnItem(ItemID.PineTreeBlock, Main.rand.Next(20, 50));
										break;
									case ItemID.CandyCaneBlock:
										player.QuickSpawnItem(ItemID.CandyCaneBlock, Main.rand.Next(20, 50));
										break;
									case ItemID.GreenCandyCaneBlock:
										player.QuickSpawnItem(ItemID.GreenCandyCaneBlock, Main.rand.Next(20, 50));
										break;
									default:
										player.QuickSpawnItem(presentrandom);
										break;
								}
								presentrandom.Clear();
							}
							return false;
						}
						else
						{
							return true;
						}
					}

				case "goodieBag":
					{
						PresentOpenerConfig config = new PresentOpenerConfig();

						if (!config.goodiemenu.DisableGoodieConfig)
						{
							WeightedRandom<int> goodierandom = new WeightedRandom<int>();

							goodierandom.Add(ItemID.UnluckyYarn, 19f / 150f * config.goodiemenu.GoodieRareItemScale);
							goodierandom.Add(ItemID.BatHook, 19f / 150f * config.goodiemenu.GoodieRareItemScale);
							goodierandom.Add(ItemID.MorbidCuriosity, 19f / 50f * config.goodiemenu.PaintingScale);
							goodierandom.Add(ItemID.BitterHarvest, 19f / 50f * config.goodiemenu.PaintingScale);
							goodierandom.Add(ItemID.BloodMoonCountess, 19f / 50f * config.goodiemenu.PaintingScale);
							goodierandom.Add(ItemID.HallowsEve, 19f / 50f * config.goodiemenu.PaintingScale);
							goodierandom.Add(ItemID.JackingSkeletron, 19f / 50f * config.goodiemenu.PaintingScale);
							goodierandom.Add(ItemID.CatEars, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.CatMask, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.CreeperMask, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.PumpkinMask, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.SpaceCreatureMask, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.KarateTortoiseMask, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.FoxMask, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.WitchHat, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.VampireMask, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.LeprechaunHat, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.RobotMask, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.PrincessHat, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.TreasureHunterShirt, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.WolfMask, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.UnicornMask, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.ReaperHood, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.PixieShirt, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.BrideofFrankensteinMask, 1f * config.goodiemenu.CostumeScale);
							goodierandom.Add(ItemID.GhostMask, 1f * config.goodiemenu.CostumeScale);

							Mod SpiritMod = ModLoader.GetMod("SpiritMod");
							if (SpiritMod != null && config.moddedmenu.DisableModdedConfigs == false)
							{
								WeightedRandom<int> MaskRandom = new WeightedRandom<int>();
								MaskRandom.Add(SpiritMod.ItemType("MaskHulk"));
								MaskRandom.Add(SpiritMod.ItemType("MaskIggy"));
								MaskRandom.Add(SpiritMod.ItemType("MaskSvante"));
								MaskRandom.Add(SpiritMod.ItemType("MaskLeemyy"));
								MaskRandom.Add(SpiritMod.ItemType("MaskSchmo"));
								MaskRandom.Add(SpiritMod.ItemType("MaskLordCake"));
								MaskRandom.Add(SpiritMod.ItemType("MaskYuyutsu"));
								MaskRandom.Add(SpiritMod.ItemType("MaskVladimier"));
								MaskRandom.Add(SpiritMod.ItemType("MaskGraydee"));
								MaskRandom.Add(SpiritMod.ItemType("MaskBlaze"));
								MaskRandom.Add(SpiritMod.ItemType("MaskKachow"));
								if (Main.rand.Next(25) <= 5f * config.moddedmenu.SpiritDevMaskScale)
								{
									player.QuickSpawnItem(MaskRandom);
								}

								WeightedRandom<int> candyrandom = new WeightedRandom<int>();
								candyrandom.Add(SpiritMod.ItemType("Taffy"), 1f / 8f * config.moddedmenu.SpiritCandyScale);
								candyrandom.Add(SpiritMod.ItemType("Candy"), 7f / 25f * config.moddedmenu.SpiritCandyScale);
								candyrandom.Add(SpiritMod.ItemType("ChocolateBar"), 12f / 25f * config.moddedmenu.SpiritCandyScale);
								candyrandom.Add(SpiritMod.ItemType("HealthCandy"), 29f / 50f * config.moddedmenu.SpiritCandyScale);
								candyrandom.Add(SpiritMod.ItemType("ManaCandy"), 17f / 25f * config.moddedmenu.SpiritCandyScale);
								candyrandom.Add(SpiritMod.ItemType("Lollipop"), 39f / 50f * config.moddedmenu.SpiritCandyScale);
								candyrandom.Add(SpiritMod.ItemType("Apple"), 100f / 83f * config.moddedmenu.AppleScale);
								candyrandom.Add(SpiritMod.ItemType("MysteryCandy"), 25f / 24f * config.moddedmenu.MysteryCandyScale);
								candyrandom.Add(SpiritMod.ItemType("GoldCandy"), 3f / 100f);
								player.QuickSpawnItem(candyrandom);
							}

							if (goodierandom != null)
							{
								switch (goodierandom)
								{
									case ItemID.RottenEgg:
										player.QuickSpawnItem(goodierandom, Main.rand.Next(10, 41));
										break;
									case ItemID.CatMask:
										player.QuickSpawnItem(ItemID.CatMask);
										player.QuickSpawnItem(ItemID.CatShirt);
										player.QuickSpawnItem(ItemID.CatPants);
										break;
									case ItemID.CreeperMask:
										player.QuickSpawnItem(ItemID.CreeperMask);
										player.QuickSpawnItem(ItemID.CreeperShirt);
										player.QuickSpawnItem(ItemID.CreeperPants);
										break;
									case ItemID.PumpkinMask:
										player.QuickSpawnItem(ItemID.PumpkinMask);
										player.QuickSpawnItem(ItemID.PumpkinShirt);
										player.QuickSpawnItem(ItemID.PumpkinPants);
										break;
									case ItemID.SpaceCreatureMask:
										player.QuickSpawnItem(ItemID.SpaceCreatureMask);
										player.QuickSpawnItem(ItemID.SpaceCreatureShirt);
										player.QuickSpawnItem(ItemID.SpaceCreaturePants);
										break;
									case ItemID.KarateTortoiseMask:
										player.QuickSpawnItem(ItemID.KarateTortoiseMask);
										player.QuickSpawnItem(ItemID.KarateTortoiseShirt);
										player.QuickSpawnItem(ItemID.KarateTortoisePants);
										break;
									case ItemID.FoxMask:
										player.QuickSpawnItem(ItemID.FoxMask);
										player.QuickSpawnItem(ItemID.FoxShirt);
										player.QuickSpawnItem(ItemID.FoxPants);
										break;
									case ItemID.WitchHat:
										player.QuickSpawnItem(ItemID.WitchHat);
										player.QuickSpawnItem(ItemID.WitchDress);
										player.QuickSpawnItem(ItemID.WitchBoots);
										break;
									case ItemID.VampireMask:
										player.QuickSpawnItem(ItemID.VampireMask);
										player.QuickSpawnItem(ItemID.VampireShirt);
										player.QuickSpawnItem(ItemID.VampirePants);
										break;
									case ItemID.LeprechaunHat:
										player.QuickSpawnItem(ItemID.LeprechaunHat);
										player.QuickSpawnItem(ItemID.LeprechaunShirt);
										player.QuickSpawnItem(ItemID.LeprechaunPants);
										break;
									case ItemID.RobotMask:
										player.QuickSpawnItem(ItemID.RobotMask);
										player.QuickSpawnItem(ItemID.RobotShirt);
										player.QuickSpawnItem(ItemID.RobotPants);
										break;
									case ItemID.PrincessHat:
										player.QuickSpawnItem(ItemID.PrincessHat);
										player.QuickSpawnItem(ItemID.PrincessDressNew);
										break;
									case ItemID.TreasureHunterShirt:
										player.QuickSpawnItem(ItemID.TreasureHunterShirt);
										player.QuickSpawnItem(ItemID.TreasureHunterPants);
										break;
									case ItemID.WolfMask:
										player.QuickSpawnItem(ItemID.WolfMask);
										player.QuickSpawnItem(ItemID.WolfShirt);
										player.QuickSpawnItem(ItemID.WolfPants);
										break;
									case ItemID.UnicornMask:
										player.QuickSpawnItem(ItemID.UnicornMask);
										player.QuickSpawnItem(ItemID.UnicornShirt);
										player.QuickSpawnItem(ItemID.UnicornPants);
										break;
									case ItemID.ReaperHood:
										player.QuickSpawnItem(ItemID.ReaperHood);
										player.QuickSpawnItem(ItemID.ReaperRobe);
										break;
									case ItemID.PixieShirt:
										player.QuickSpawnItem(ItemID.PixieShirt);
										player.QuickSpawnItem(ItemID.PixiePants);
										break;
									case ItemID.BrideofFrankensteinMask:
										player.QuickSpawnItem(ItemID.BrideofFrankensteinMask);
										player.QuickSpawnItem(ItemID.BrideofFrankensteinDress);
										break;
									case ItemID.GhostMask:
										player.QuickSpawnItem(ItemID.GhostMask);
										player.QuickSpawnItem(ItemID.GhostShirt);
										break;
									default:
										player.QuickSpawnItem(goodierandom);
										break;
								}
								goodierandom.Clear();
							}
							return false;
						}
						else
						{
							return true;
						}
					}

				default:
					return true;
			}
		}
	}
}
