using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using MarteAria.Items.Weapons;

namespace MarteAria.Items.Weapons
{
    public class Pistola_Energetica : ModItem
    {
        public override void SetStaticDefaults(){
            DisplayName.SetDefault("Pistola Energetica");
            Tooltip.SetDefault("Zap! fece la signorina...");
        }

        public override void SetDefaults(){
            item.damage = 20;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 1;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.useStyle = 5;
            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 22f;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.useAmmo = mod.ItemType("BFG_Cell"); //ammo moddato creato su misura
        }

    }
}
