using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Comenzo.Projectiles
{
	public class TerraBeam : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("The True Destoryer V2");
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.TerraBeam);
			aiType = ProjectileID.TerraBeam;
		}


		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.TerraBeam;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, ProjectileID.Starfury, (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}
	}
}