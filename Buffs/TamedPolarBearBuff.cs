using Terraria;
using Terraria.ModLoader;

namespace YaxilMod.Buffs
{
    public class TamedPolarBearBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Polar Bear");
            Description.SetDefault("A loyal companion with a cold heart.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("TamedPolarBear"), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}