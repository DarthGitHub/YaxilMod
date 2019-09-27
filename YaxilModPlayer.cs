using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameInput;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework.Graphics;

namespace YaxilMod
{
    public class YaxilModPlayer : ModPlayer
    {
        //When dealing with stamina, all values have to get multiplied by 10!!! For example, if earlier punch took 5, now it should take 50. 
        //This was done for the fluidity of the bar.

        #region Values
        private static double _stamina = 1000;
        public static double MaxStamina = 1000;
        public static bool UIShow = true;

        public static double Stamina
        {
            get { return _stamina; }
            set
            {
                _stamina = value;
                if (value > MaxStamina)
                    _stamina = MaxStamina;
                if (value < 0)
                    _stamina = 0;
            }
        }
        #endregion


        public static YaxilModPlayer Get(Player player)
        {
            return player.GetModPlayer<YaxilModPlayer>();
        }

        public override void PreUpdate()
        {
            if (Stamina < MaxStamina)
                _stamina += 0.83;
        }

        public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath)
        {
            Item item = new Item();
            item.SetDefaults(mod.ItemType("LuminousShard"));
            item.stack = 1;
            items.Add(item);
        }

        public override void ResetEffects()
        {
            player.statLifeMax2 += YaxilModLifeFruits * 21750;
        }

        public int score = 0;
        private const int maxYaxilModLifeFruits = 10;
        public int YaxilModLifeFruits = 0;

        internal enum YaxilModMessageType : byte
        {
            YaxilModLifeFruits
        }
        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer)
        {
            ModPacket packet = mod.GetPacket();
            packet.Write((byte)YaxilModMessageType.YaxilModLifeFruits);
            packet.Write((byte)player.whoAmI);
            packet.Write(YaxilModLifeFruits);
            packet.Send(toWho, fromWho);
        }

        public override TagCompound Save()
        {
            return new TagCompound {
				// {"somethingelse", somethingelse}, // To save more data, add additional lines
				{"score", score},
                {"YaxilModLifeFruits", YaxilModLifeFruits},
            };
            //note that C# 6.0 supports indexer initializers
            //return new TagCompound {
            //	["score"] = score
            //};
        }

        public override void Load(TagCompound tag)
        {
            score = tag.GetInt("score");
            YaxilModLifeFruits = tag.GetInt("YaxilModLifeFruits");
        }
    }
}