using Harmony;

namespace ForcedDuplicant
{
	[HarmonyPatch(typeof(Telepad), nameof(Telepad.Update))]
	public static class ChallengeMod
	{
		public static void Prefix(Telepad __instance)
		{
			if (Immigration.Instance.ImmigrantsAvailable)
			{
				__instance.OnAcceptDelivery(new MinionStartingStats(false));
				__instance.RejectAll();
			}
		}
	}
}
