using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.NPCs
{
    public class DemonicTotem : ModNPC
    {
        public bool faceTarget = false;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Demonic Totem");
            Main.npcFrameCount[npc.type] = 10;
        }

        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 32;
            npc.aiStyle = 44;
            npc.damage = 30;
            npc.defense = 5;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath62;
            npc.value = 25f;
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter += 0.8f;
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;

            npc.spriteDirection = npc.direction;
        }
        
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.SurfaceJungle.Chance * 0.2f;
        }

        public override void AI()
        {
            npc.TargetClosest(faceTarget);
            Player player = Main.player[npc.target];
            Vector2 moveTo = player.Center + new Vector2(-50f, 0f);
        }
    }
}
