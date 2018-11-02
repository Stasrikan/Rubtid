using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Rubtid.Items;
namespace Rubtid.mobs
{
  public class Tabloid :  ModNPCs
  {
    public override void SetStaticDefauls()
    {
      DisplayName.SetDefault("Tabloid");
    }
    public override void SetDefaults()
    {
       npc.lifeMax = 50;
       npc.damage = 10;
       npc.defence = 2;
       npc.width = 64;
       npc.height = 64;
       npc.aiStyle = 26;
       npc.hitSound =SoundID.NPCHit6;
       npc.DeathSound = SoundID.NPCDeath5;
       }
       public override float CanSpawn(NPCSpawnInfo spawnInfo)
       {
        return spawnInfo.spawnTileY < Main.rockLaye ? 0.08f : 0f;
        }
        
        
    
 
     
       
