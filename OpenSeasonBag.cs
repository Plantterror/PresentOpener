using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace PresentOpener.Globals
{
	public class OpenSeasonBag : GlobalItem //This class is solely to adjust the Present and Goodie bag chances to fit the config.
	{
		public override bool PreOpenVanillaBag(string context, Player player, int arg)
		{
			switch (context)
			{
				case "present":
					{
						PresentOpenerConfig config = ModContent.GetInstance<PresentOpenerConfig>();
						WeightedRandom<short> presentrandom = new WeightedRandom<short>(); //This is a form of randomness made by Terraria, useful for avoiding long If/Else chains like I have previously done.

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


						if (presentrandom != null)
						{

							if (presentrandom == ItemID.RedRyder)
							{
								player.QuickSpawnItem(presentrandom);
								player.QuickSpawnItem(ItemID.MusketBall, Main.rand.Next(30, 61));
							}
							else if (presentrandom == ItemID.MrsClauseHat)
							{
								player.QuickSpawnItem(ItemID.MrsClauseHat);
								player.QuickSpawnItem(ItemID.MrsClauseShirt);
								player.QuickSpawnItem(ItemID.MrsClauseHeels);
							}
							else if (presentrandom == ItemID.ParkaHood)
							{
								player.QuickSpawnItem(ItemID.ParkaHood);
								player.QuickSpawnItem(ItemID.ParkaCoat);
								player.QuickSpawnItem(ItemID.ParkaPants);
							}
							else if (presentrandom == ItemID.TreeMask)
							{
								player.QuickSpawnItem(ItemID.TreeMask);
								player.QuickSpawnItem(ItemID.TreeShirt);
								player.QuickSpawnItem(ItemID.TreeTrunks);
							}
							else if (presentrandom == ItemID.Eggnog)
							{
								player.QuickSpawnItem(ItemID.Eggnog, Main.rand.Next(1, 4));
							}
							else if (presentrandom == ItemID.StarAnise)
							{
								player.QuickSpawnItem(ItemID.StarAnise, Main.rand.Next(20, 41));
							}
							else if (presentrandom == ItemID.PineTreeBlock)
							{
								player.QuickSpawnItem(ItemID.PineTreeBlock, Main.rand.Next(20, 50));
							}
							else if (presentrandom == ItemID.CandyCaneBlock)
							{
								player.QuickSpawnItem(ItemID.CandyCaneBlock, Main.rand.Next(20, 50));
							}
							else if (presentrandom == ItemID.GreenCandyCaneBlock)
							{
								player.QuickSpawnItem(ItemID.GreenCandyCaneBlock, Main.rand.Next(20, 50));
							}
							else
							{
								player.QuickSpawnItem(presentrandom);
							}
							presentrandom.Clear();
						}
						return false;
					}

				case "goodieBag":
					{
						PresentOpenerConfig config = ModContent.GetInstance<PresentOpenerConfig>();
						WeightedRandom<short> goodierandom = new WeightedRandom<short>();

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
						if (goodierandom != null)
						{
							if (goodierandom == ItemID.RottenEgg)
							{
								player.QuickSpawnItem(goodierandom, Main.rand.Next(10, 41));
							}
							else if (goodierandom == ItemID.CatMask)
							{
								player.QuickSpawnItem(ItemID.CatMask);
								player.QuickSpawnItem(ItemID.CatShirt);
								player.QuickSpawnItem(ItemID.CatPants);
							}
							else if (goodierandom == ItemID.CreeperMask)
							{
								player.QuickSpawnItem(ItemID.CreeperMask);
								player.QuickSpawnItem(ItemID.CreeperShirt);
								player.QuickSpawnItem(ItemID.CreeperPants);
							}
							else if (goodierandom == ItemID.PumpkinMask)
							{
								player.QuickSpawnItem(ItemID.PumpkinMask);
								player.QuickSpawnItem(ItemID.PumpkinShirt);
								player.QuickSpawnItem(ItemID.PumpkinPants);
							}
							else if (goodierandom == ItemID.SpaceCreatureMask)
							{
								player.QuickSpawnItem(ItemID.SpaceCreatureMask);
								player.QuickSpawnItem(ItemID.SpaceCreatureShirt);
								player.QuickSpawnItem(ItemID.SpaceCreaturePants);
							}
							else if (goodierandom == ItemID.KarateTortoiseMask)
							{
								player.QuickSpawnItem(ItemID.KarateTortoiseMask);
								player.QuickSpawnItem(ItemID.KarateTortoiseShirt);
								player.QuickSpawnItem(ItemID.KarateTortoisePants);
							}
							else if (goodierandom == ItemID.FoxMask)
							{
								player.QuickSpawnItem(ItemID.FoxMask);
								player.QuickSpawnItem(ItemID.FoxShirt);
								player.QuickSpawnItem(ItemID.FoxPants);
							}
							else if (goodierandom == ItemID.WitchHat)
							{
								player.QuickSpawnItem(ItemID.WitchHat);
								player.QuickSpawnItem(ItemID.WitchDress);
								player.QuickSpawnItem(ItemID.WitchBoots);
							}
							else if (goodierandom == ItemID.VampireMask)
							{
								player.QuickSpawnItem(ItemID.VampireMask);
								player.QuickSpawnItem(ItemID.VampireShirt);
								player.QuickSpawnItem(ItemID.VampirePants);
							}
							else if (goodierandom == ItemID.LeprechaunHat)
							{
								player.QuickSpawnItem(ItemID.LeprechaunHat);
								player.QuickSpawnItem(ItemID.LeprechaunShirt);
								player.QuickSpawnItem(ItemID.LeprechaunPants);
							}
							else if (goodierandom == ItemID.RobotMask)
							{
								player.QuickSpawnItem(ItemID.RobotMask);
								player.QuickSpawnItem(ItemID.RobotShirt);
								player.QuickSpawnItem(ItemID.RobotPants);
							}
							else if (goodierandom == ItemID.PrincessHat)
							{
								player.QuickSpawnItem(ItemID.PrincessHat);
								player.QuickSpawnItem(ItemID.PrincessDressNew);
							}
							else if (goodierandom == ItemID.TreasureHunterShirt)
							{
								player.QuickSpawnItem(ItemID.TreasureHunterShirt);
								player.QuickSpawnItem(ItemID.TreasureHunterPants);
							}
							else if (goodierandom == ItemID.WolfMask)
							{
								player.QuickSpawnItem(ItemID.WolfMask);
								player.QuickSpawnItem(ItemID.WolfShirt);
								player.QuickSpawnItem(ItemID.WolfPants);
							}
							else if (goodierandom == ItemID.UnicornMask)
							{
								player.QuickSpawnItem(ItemID.UnicornMask);
								player.QuickSpawnItem(ItemID.UnicornShirt);
								player.QuickSpawnItem(ItemID.UnicornPants);
							}
							else if (goodierandom == ItemID.ReaperHood)
							{
								player.QuickSpawnItem(ItemID.ReaperHood);
								player.QuickSpawnItem(ItemID.ReaperRobe);
							}
							else if (goodierandom == ItemID.PixieShirt)
							{
								player.QuickSpawnItem(ItemID.PixieShirt);
								player.QuickSpawnItem(ItemID.PixiePants);
							}
							else if (goodierandom == ItemID.BrideofFrankensteinMask)
							{
								player.QuickSpawnItem(ItemID.BrideofFrankensteinMask);
								player.QuickSpawnItem(ItemID.BrideofFrankensteinDress);
							}
							else if (goodierandom == ItemID.GhostMask)
							{
								player.QuickSpawnItem(ItemID.GhostMask);
								player.QuickSpawnItem(ItemID.GhostShirt);
							}
							else
							{
								player.QuickSpawnItem(goodierandom);
							}
							goodierandom.Clear();
						}
						return false;
					}

				default:
					return true;
			}
		}
	}
}
