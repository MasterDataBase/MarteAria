using Terraria.ID;
using Terraria.ModLoader;

namespace DoomTest.Items
{
	public class Argent_Energy : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Argent Energy");
			Tooltip.SetDefault("This is a modded sword.");
		}
		public override void SetDefaults()
		{
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 6;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Argent_Plasma"), 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
