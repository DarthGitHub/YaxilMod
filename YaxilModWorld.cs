using System.Collections.Generic;
using Terraria.ID;
using Terraria.World.Generation;
using Terraria.GameContent.Generation;
using Terraria;
using Terraria.ModLoader;


namespace YaxilMod
{
    class YaxilModWorld : ModWorld
    {


        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Mini Biomes"));
            tasks.Insert(genIndex + 1, new PassLegacy("Dirt Blob", dirtblob));
        }
        public static void dirtblob(GenerationProgress progress)
        {
            Main.tile[100, 100].type = TileID.Dirt;
            for (var x = 0; x < Main.maxTilesX; x++)
            {
                for (var y = 0; y < Main.maxTilesY; y++)
                {
                    int check = Main.rand.Next(0, 1000);
                    if (check == 1)
                    {
                    }
                }
            }
        }
    }
}

