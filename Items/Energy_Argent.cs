using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarteAria.Items {

    public class Energy_Argent : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Energy Argent");
            Tooltip.SetDefault("This is the powerfull Argent energy.");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 40;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item1;

            // Questa linea permette di stackare l'oggeto fino a un limite di X
            item.maxStack = 999;
            
            //item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            // You can just insert AddIngredient for each ingredient you would
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            //recipe.AddIngredient(23, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
