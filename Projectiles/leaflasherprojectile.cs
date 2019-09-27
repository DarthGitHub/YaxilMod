using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YaxilMod.Projectiles
{
    public class leaflasherprojectile : ModProjectile
        {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leaf Lasher Projectile");
        }
        public override void SetDefaults()
        {
			projectile.width = 8;               
			projectile.height = 8;
            aiType = ProjectileID.Bullet;             
			projectile.friendly = true;         
			projectile.hostile = false;         
			projectile.melee = true;           
			projectile.penetrate = 5;           
			projectile.timeLeft = 6000;         
			projectile.light = 0.9f;           
			projectile.ignoreWater = true;          
			projectile.tileCollide = true;          
			projectile.extraUpdates = 1;
		}
    }
 
}

	

    
    
