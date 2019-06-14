using Terraria.ID;
using Terraria.ModLoader;

namespace MarteAria.Items
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
            item.value = 10;
            item.rare = 10;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Argent_Energy"), 10);//fa in modo che venga craftato da 10 unita di "Argent_Energy"
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
