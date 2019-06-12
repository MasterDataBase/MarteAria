using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarteAria.NPCs{

    public class ModGlobalNPC : GlobalNPC{

        public override void NPCLoot(NPC npc)
        {
            Item.NewItem(npc.getRect(), ItemID.Beenade, 20);
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.IronBar);
            Item.NewItem(npc.getRect(), mod.ItemType("Energia_Argent"));
        }
    }
}