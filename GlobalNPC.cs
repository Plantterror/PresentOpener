using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace PresentOpener
{
	public class NPCDrops : GlobalNPC //This will allow the mod to edit vanilla NPC drops...
	{
		public override void NPCLoot(NPC npc)
		{
			if (!Main.halloween && npc.lifeMax > 1 && npc.damage > 0 && !npc.friendly && npc.type != 121 && npc.type != 23 && npc.value > 0f && Main.rand.Next(240) == 0)
			{
				Item.NewItem(npc.getRect(), ItemID.GoodieBag); //All NPCs have about a 1/3 chance less of dropping a goodie bag if halloween is not enabled.
			}
			if (!Main.xMas && npc.lifeMax > 1 && npc.damage > 0 && !npc.friendly && npc.type != 121 && npc.value > 0f && Main.rand.Next(39) == 0)
			{
				Item.NewItem(npc.getRect(), ItemID.Present); //Same here for Presents.
			}
		}
	}
}