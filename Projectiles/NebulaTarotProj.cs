using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.Projectiles
{
    public class NebulaTarotProj : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.width = 20;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.penetrate = 2;
            projectile.extraUpdates = 1;
            projectile.timeLeft = 500;
            projectile.aiStyle = 1;          
            aiType = ProjectileID.Bullet;
            Main.projFrames[projectile.type] = 14;

        }


        public override bool PreDraw(SpriteBatch sb, Color lightColor) 
        {
            projectile.frameCounter++; 
            if (projectile.frameCounter >= 14) 
            {
                projectile.frame++; 
                projectile.frameCounter = 0;
                if (projectile.frame > 3) 
                    projectile.frame = 0; 
            }
            return true;
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            {
                projectile.Kill();

                Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10);
            }
            return false;
        }
    }
}