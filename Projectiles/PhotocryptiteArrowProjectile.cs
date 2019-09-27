using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.Projectiles
{
    public class PhotocryptiteArrowProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("PhotocryptiteArrowProjectile");
        }
        public override void SetDefaults()
        {
            projectile.width = 8; 
            projectile.height = 8;  
            projectile.aiStyle = 1; 
            projectile.friendly = true;  
            projectile.hostile = false; 
            projectile.tileCollide = true; 
            projectile.ignoreWater = true; 
            projectile.ranged = true;  
            projectile.penetrate = 1; 
            projectile.timeLeft = 400;
            projectile.light = 0.10f;
            aiType = 1; 
        }
      

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) 
        {

            target.AddBuff(BuffID.Poisoned, 510);   

        }

    }
}