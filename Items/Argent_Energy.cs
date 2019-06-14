using Terraria.ID;
using Terraria.ModLoader;

namespace MarteAria.Items
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
            item.width = 10;
            item.height = 10;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 6;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Argent_Plasma"), 10); //fa in modo che venga craftato da 10 unita di "Argent_Plasma"
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
