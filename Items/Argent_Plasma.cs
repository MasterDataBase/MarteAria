using Terraria.ID;
using Terraria.ModLoader;

namespace MarteAria.Items
{
    public class Argent_Plasma : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Argent Plasma");
            Tooltip.SetDefault("A new form of renewable energy");
        }
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 10;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 3;
        }
    }
}
