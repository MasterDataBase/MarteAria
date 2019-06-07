using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DoomTest.NPCs
{
    public class Possessed : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Possessed");
        }

        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 40;
            npc.damage = 12;
            npc.defense = 5;
            npc.lifeMax = 100;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f; //soldi che vengono droppati alla kill
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 3; //uguale a aiType
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie]; //Main.npcFrameCount[3];
            aiType = NPCID.Zombie; // aiType = 3;
            animationType = NPCID.Zombie; // animationType = 3;

            npc.buffImmune[BuffID.OnFire] = true; //immune al debuff "On Fire"
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Underworld.Chance * 0.3f; // spawn nell'underworld(inferno) al 38% (è molto complicato capire queste percentuali)
        }

        public override void NPCLoot()
        {
            if (Main.rand.NextFloat() < .50f) //50% di possibilità di drop
            {
               Item.NewItem(npc.getRect(), mod.ItemType("Argent_Plasma"), Main.rand.Next(2, 6)); // droppa da 2 a 5 "Argent_Plasma"
            }
        }
    }
}
