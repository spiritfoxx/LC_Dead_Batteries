using HarmonyLib;

namespace DeadBatteries.Patches
{
    [HarmonyPatch(typeof(GrabbableObject))]
    internal class DeadBatteriesPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        static void Patch(ref Battery ___insertedBattery, ref Item ___itemProperties)
        {
            if (___itemProperties.requiresBattery)
            {
                ___insertedBattery = new Battery(true, 0f);
            }
        }
    }
}
