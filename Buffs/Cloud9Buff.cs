using Terraria;
using Terraria.ModLoader;

namespace YaxilMod.Buffs
{
    public class Cloud9Buff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Cloud 9");
            Description.SetDefault("Feels like you're in heaven.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("Cloud9"), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}
