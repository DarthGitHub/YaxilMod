using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.Projectiles
{
    public class SporeBurstStaffProj : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 40;
            projectile.height = 40;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }

        public override void AI()
        {
            projectile.width += 1;
            projectile.height += 1;
            projectile.position -= new Vector2(1, 1);
            projectile.scale += 0.01f;
        }

    }
}
