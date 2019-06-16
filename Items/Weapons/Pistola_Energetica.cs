using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using MarteAria.Items.Weapons;

// A deep journey into -> come cazzo si crea un arma? 

namespace MarteAria.Items.Weapons
{
    public class Pistola_Energetica : ModItem
    {
        public override void SetStaticDefaults(){
            DisplayName.SetDefault("Pistola Energetica");
            Tooltip.SetDefault("Zap! fece la signorina...");
        }

        public override void SetDefaults(){
            item.damage = 20;           // Danno inflitto
            item.width = 10;
            item.height = 10;

            // Terraria Type
            item.ranged = true;                 // Tipo di danno inflitto -> Ranged
            item.noMelee = true;                // So the item's animation doesn't do damage
            item.useAnimation = 15;             // Speed of the 
            item.knockBack = 4;
            //item.useStyle = 4;                  // Holding up style use (summon)
            item.useStyle = 5;
            item.useTime = 15;                  // Quanto velocemente più essere usata
            item.UseSound = SoundID.Item12;     // 12 Laser gun
            item.autoReuse = false;

            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 25f;

            //Laser Pistol
            //item.useAmmo = AmmoID.Bullet;

            //Shotgun
            //item.useAmmo = mod.ItemType("BFG_Cell"); //ammo moddato creato su misura

            //
            item.useAmmo = mod.ItemType("BFG_Sphere"); //Non consuma ammo!?
        }

    }
}
