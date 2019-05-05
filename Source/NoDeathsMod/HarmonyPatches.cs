using Harmony;

namespace NoDeathsMod
{
	[HarmonyPatch(typeof(MinionIdentity), "OnDied")]
	public static class NoDeathsMod
	{
		public static void Postfix()
		{
			for (int i = 0; i < Components.LiveMinionIdentities.Count; i++)
			{
				Health health = Components.LiveMinionIdentities[i].GetComponent<Health>();
				if (health != null)
				{
					// kill them really dead
					health.Damage(float.MaxValue);
				}
			}
		}
	}
}