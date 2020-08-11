﻿using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Comenzo.Items.Placeable.MagmaOre
{
	public class MagmaOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = TileType<Tiles.Ore.MagmaOre.MagmaOre>();
			item.width = 12;
			item.height = 12;
			item.value = 3000;
		}
	}
}
