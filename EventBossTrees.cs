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
                if(Main.rand.NextFloat() < .15f) 
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("PresentProcessor"));
                }
                    
            }
            if(npc.type == NPCID.MourningWood)
            {
                if (Main.rand.NextFloat() < .15f)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("GoodieProcessor"));
                }
            }
        }
    }
}