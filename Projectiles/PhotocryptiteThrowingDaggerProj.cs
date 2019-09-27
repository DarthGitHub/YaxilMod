using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.Projectiles
{
    public class PhotocryptiteThrowingDaggerProj : ModProjectile
    {

        public override void SetDefaults()
        {  
            projectile.width = 20;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.aiStyle = 1;
            projectile.thrown = true;
            projectile.penetrate = 2;      
            projectile.extraUpdates = 1;
            aiType = ProjectileID.VampireKnife;
        }

        public override void AI()
        {
            projectile.ai[0] += 1f;
            if (projectile.ai[0] >= 50f)      
            {
                projectile.velocity.Y = projectile.velocity.Y + 0.15f;    
                projectile.velocity.X = projectile.velocity.X * 0.99f;    
            }
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