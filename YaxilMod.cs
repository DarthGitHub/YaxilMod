
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;
using Terraria.Localization;

namespace YaxilMod
{
    class YaxilMod : Mod
    {
        public override void AddRecipeGroups()
        {
            // Creates a new recipe group
            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Lang.GetItemNameValue(ItemType("JungleCells")), new[]
            {
                ItemType("JungleCells")
            });
            // Registers the new recipe group with the specified name
            RecipeGroup.RegisterGroup("YaxilMod:JungleCells", group);
        }
    }
}