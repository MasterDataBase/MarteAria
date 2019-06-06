// Outside the code è necessario che tu crei un nuovo folder dentro a quello principale
    della mod che si chiami "NPCs", il file deve chiamarsi inoltre
    '' -> Inserisci i tuoi valori

using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

// Inserisci il namespace scrivendo 'NomeMod'.NPCs
namespace 'NomeMod'.NPCs{
    public class 'NomeFile' : GlobalNPC{
        public override void NPCLood(NPC npc){
            // Cosi tutti droppano questo oggetto
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType('Qui il nome dell'oggetto mod'));
        }
    }
}
