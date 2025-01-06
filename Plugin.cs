using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using NoTrafficModNRP.HPatchers;

namespace NoTrafficModNRP
{
    internal static class PluginInfo
    {
        public const string PLUGIN_GUID = "me.ofireyeees.nightrunners.notraffic";
        public const string PLUGIN_NAME = "No Traffic Mod";
        public const string PLUGIN_VERSION = "0.1.0";
    };

    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BasePlugin
    {
        internal static new ManualLogSource Log;

        public override void Load()
        {
            Harmony.CreateAndPatchAll(typeof(HPatch));

            Log = base.Log;
            Log.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}