using Terraria.ModLoader;

namespace TheHeroIeralian
{
	class TheHeroIeralian : Mod
	{
		public TheHeroIeralian()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
