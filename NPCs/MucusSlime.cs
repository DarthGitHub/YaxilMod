using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.NPCs
{
    public class MucusSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mucus Slime");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
        }

        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 32;
            npc.aiStyle = 1; 
            npc.damage = 15;
            npc.defense = 1;
            npc.lifeMax = 25;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 25f;
            aiType = NPCID.BlueSlime;
            animationType = NPCID.BlueSlime;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 0.5f;
        }

        public override void NPCLoot()
        {
            if (Main.rand.NextFloat() < .3333f)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("Mucus"));
            }
        }
    }
}