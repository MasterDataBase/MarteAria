using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using MarteAria.Items.Weapons;

namespace MarteAria.Items.Weapons{
    
    public class SuperBullet : ModItem{

        public override void SetStaticDefaults(){
            Tooltip.SetDefault("This is a modded bullet ammo.");
        }

        public override void SetDefaults(){
            item.damage = 12;
            item.width = 8;
            item.height = 8;

            item.ranged = true;

            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = .5f;

            item.shoot = mod.ProjectileType("SuperBullet");
            item.shootSpeed = 10f;
            item.ammo = AmmoID.Bullet;

            item.value = 500;
            item.rare = 4;
        }
    }
}