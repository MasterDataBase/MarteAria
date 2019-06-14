using Terraria.ID;
using Terraria.ModLoader;

namespace MarteAria.Items.Weapons
{
    public class BFG : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("BFG 9000");
            Tooltip.SetDefault("This is a Big Fucking Gun");
        }
        public override void SetDefaults()
        {
            item.damage = 66666666;
            item.ranged = true;
            item.width = 20;
            item.height = 10;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 10000000;
            item.rare = 2;
            item.autoReuse = false;
            //item.shoot = mod.ProjectileType("SferaBFG"); ; // 254=magnet sphere, quello più simile per adesso
            //item.shoot = mod.ProjectileType("BFG_Sphere");
            item.shoot = 10;
            item.shootSpeed = 16f;
            item.useAmmo = mod.ItemType("BFG_Cell"); //ammo moddato creato su misura
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
