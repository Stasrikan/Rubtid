using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Rubtid.Items
{
    public class item : ModItem
	{
		public override void SetDefaults()
    {
        

        item.damage = 228;
        item.melee = true;
        item.width = 40;
        item.height = 40;
        item.useTime = 8;
        item.useAnimation = 8;
        item.useStyle = 1;
        item.knockBack = 6;
        item.value = 10000;
        item.rare = 2;
        item.UseSound = SoundID.Item1;
        item.autoReuse = true;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("цюбмн228");
            Tooltip.SetDefault("опнярн упемэ!");
        }

    }
}
