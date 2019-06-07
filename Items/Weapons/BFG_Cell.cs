using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DoomTest.Items.Weapons
{
    public class BFG_Cell : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("BFG Cell");
            Tooltip.SetDefault("Ammo Imbued with too much energy");
        }

        public override void SetDefaults()
        {
            item.damage = 1;
            item.ranged = true;
            item.width = 14;
            item.height = 14;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1f;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 8;
            item.shoot = mod.ProjectileType("BFG_Cell");
            item.ammo = item.type; // The first item in an ammo class sets the AmmoID to it's type
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Argent_Cell"), 1);//fa in modo che venga craftato da 1 unita di "Argent_Cell"
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
