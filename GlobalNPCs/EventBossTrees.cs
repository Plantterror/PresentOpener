using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace PresentOpener
{
    class EventBossTrees : GlobalNPC //This will allow the mod to edit vanilla NPC drops
    {
        public override void NPCLoot(NPC npc) //Like this.
        {
            if (npc.type == NPCID.Everscream)
            {
                if(Main.rand.NextFloat() < .05f) //I put the 5% chance after the NPC. No idea what would happen the other way around.
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("PresentProcessor"));
                }
                    
            }
            if(npc.type == NPCID.MourningWood)
            {
                if (Main.rand.NextFloat() < .05f)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("GoodieProcessor"));
                }
            }
        }
    }
}