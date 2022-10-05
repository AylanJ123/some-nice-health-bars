using BepInEx;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using CoreLib;
using HarmonyLib;
using System.Reflection;

namespace SNHB
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency(CoreLibPlugin.GUID)]
    [BepInProcess("CoreKeeper.exe")]
    public class SNHBPlugin : BasePlugin
    {
        internal static ManualLogSource logger;
        public override void Load()
        {
            logger = Log;
            Harmony harmony = new(PluginInfo.PLUGIN_GUID);
            harmony.PatchAll();
            logger.LogInfo($"{PluginInfo.PLUGIN_NAME} mod is loaded!");
            foreach (MethodBase method in harmony.GetPatchedMethods()) {
                logger.LogInfo($"{method.Name} method is loaded!");
            }
        }
    }
}
