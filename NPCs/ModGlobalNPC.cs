using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarteAria.NPCs{

    public class ModGlobalNPC : GlobalNPC{

        public override void NPCLoot(NPC npc)
        {
            // This line will drop 20 Beenade on drop for each enemy
            //Item.NewItem(npc.getRect(), ItemID.Beenade, 20);

            // This line will drop ... !Please fede help me!
            //Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.IronBar);

            // This line will drop one "Energy Argent"
            Item.NewItem(npc.getRect(), mod.ItemType("Energy_Argent"), 2);
        }
    }
}