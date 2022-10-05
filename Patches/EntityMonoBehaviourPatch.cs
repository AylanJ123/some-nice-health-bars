using HarmonyLib;
using System.Runtime.CompilerServices;

namespace SNHB.Patches
{
    [HarmonyPatch(typeof(EntityMonoBehaviour))]
    [HarmonyPatch(nameof(EntityMonoBehaviour.OnTakeDamage))]
    class EntityMonoBehaviourPatch
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        static bool Prefix(EntityMonoBehaviour __instance)
        {
            if (__instance.entityExist)
            {

            }
            return true;
        }
    }
}
