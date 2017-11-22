using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheHeroIeralian.Items.Accessory
{
	public class SummonerWish : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Summoner's Wish");
			Tooltip.SetDefault("Increases max amount of minions by 3\nIncreases minion damage by 18%\nIncreases minion knockback by 16%");
        	}

        	public override void SetDefaults()
		{
			item.width = 34;
			item.height = 34;
            		item.value = Item.buyPrice(0, 13, 86, 0);
            		item.rare = 9;
            		item.accessory = true;
        	}

        	public override void UpdateAccessory(Player player, bool hideVisual)
        	{
            		player.maxMinions += 3;
            		player.minionDamage = player.minionDamage *1.18f;
            		player.minionKB = player.minionKB * 1.16f;
        	}
    	}
}
