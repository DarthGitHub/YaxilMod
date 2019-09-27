using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.NPCs
{
    public class YaxilGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }

        public override void NPCLoot(NPC npc)
        {
            if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneOverworldHeight && Main.rand.Next(7) == 0)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("MythicalPowder"));
            }
        }
    }
}