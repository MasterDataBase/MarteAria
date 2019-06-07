using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DoomTest.Items.Weapons
{
    public class BFG_Sphere : ModProjectile
    {
       
        public override void SetDefaults()
        {
            DisplayName.SetDefault("SferaBFG");  //this is the projectile name
            projectile.width = 10;
            projectile.height = 10;
            projectile.penetrate = 10;
            projectile.friendly = true;     //this defines if the projectile is frendly
            projectile.penetrate = -1;  //this defines the projectile penetration, -1 = infinity
            projectile.tileCollide = false;   //this defines if the tile can colide with walls
            projectile.light = 0.50f;
            projectile.timeLeft = 400;
        }
    }
    public override void AI()
    {
        projectile.rotation = (float)Math.Atan2((Double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
    }
}