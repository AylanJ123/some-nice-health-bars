using HarmonyLib;
using System;
using System.Runtime.CompilerServices;
using Unity.Entities;
using UnityEngine;

namespace SNHB.Patches
{
    [HarmonyPatch(typeof(HealthCDAuthoring))]
    [HarmonyPatch(nameof(HealthCDAuthoring))]
    class HealthCDAuthoringPatch
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        static bool Prefix(ComponentSystem __instance)
        {
            SNHBPlugin.logger.LogInfo(__instance.GetType().Name);
            return true;
            Component component;
            if (!(__instance is HealOtherEntityStateCDAuthoringConversion))
            {
                SNHBPlugin.logger.LogInfo(__instance.GetType().Name + ", didn't work");
                return true;
            }
            try
            {
                HealthCDAuthoring authoring = (HealthCDAuthoring) component;
                SNHBPlugin.logger.LogInfo(authoring.name + ", worked");
            }
            catch(Exception e)
            {
                SNHBPlugin.logger.LogError(e);
            }
            return true;
        }
    }
}
