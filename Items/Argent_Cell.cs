using Terraria.ID;
using Terraria.ModLoader;

namespace DoomTest.Items
{
	public class Argent_Cell : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Argent Cell");
			Tooltip.SetDefault("This is a modded sword.");
		}
		public override void SetDefaults()
		{
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 10;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Argent_Energy"), 10);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
