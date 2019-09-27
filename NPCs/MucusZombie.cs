using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.NPCs
{
    public class MucusZombie : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mucus Zombie");
            Main.npcFrameCount[npc.type] = 3;
        }

        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 40;
            npc.damage = 84;
            npc.defense = 24;
            npc.lifeMax = 600;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 60f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 3;
            aiType = NPCID.Zombie;
            animationType = NPCID.Zombie;
        }
        public override void NPCLoot()
        {
            if (Main.rand.NextFloat() < .5000f)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("Mucus"));
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.25f;
        }
    }
}