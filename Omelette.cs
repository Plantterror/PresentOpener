using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace PresentOpener.Items
{
	public class Omelette : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 16;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useTurn = true;
			item.UseSound = SoundID.Item4;
			item.consumable = true;
			item.value = Item.buyPrice(silver: 5);
			item.rare = ItemRarityID.Pink;
			item.maxStack = 30;
			item.buffTime = 144000;
			item.buffType = BuffID.WellFed;
		}

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("I ordered a sandwich... Why the hell did I get this?");
		}
	}
}
