﻿namespace ForcedDuplicant
{
	public static partial class HarmonyPatches
	{
		public class ModConfig
		{
			private string configName;

			public ModConfig(string configName)
			{
				this.configName = configName;

				TryLoadConfigFromFile(configName);
			}

			private void TryLoadConfigFromFile(string s)
			{
				// var json = 
			}
		}
	}
}
