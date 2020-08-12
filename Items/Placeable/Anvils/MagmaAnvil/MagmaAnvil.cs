using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Comenzo.Items.Placeable.Anvils.MagmaAnvil
{
	public class MagmaAnvil : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Magma Anvil");
			Tooltip.SetDefault("This is a magma anvil");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.MythrilAnvil);
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 150;
			item.createTile = TileType<Tiles.Anvils.MagmaAnvil.MagmaAnvil>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MythrilAnvil);
			recipe.AddIngredient(ItemType<Items.Placeable.Bars.MagmaBar.MagmaBar>(), 10);
            recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}