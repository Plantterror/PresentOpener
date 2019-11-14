using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace PresentOpener
{
	public class EventBossTrees : GlobalNPC //This will allow the mod to edit vanilla NPC drops
	{
		public override void NPCLoot(NPC npc) //Using this hook.
		{
			if (npc.type == NPCID.Everscream)
			{
				if (Main.rand.NextFloat() < .15f) //15% chance.
				{
					Item.NewItem(npc.getRect(), mod.ItemType("PresentProcessor"));
				}

			}
			if (npc.type == NPCID.MourningWood)
			{
				if (Main.rand.NextFloat() < .15f) //15% chance.
				{
					Item.NewItem(npc.getRect(), mod.ItemType("GoodieProcessor"));
				}
			}
		}
	}
}