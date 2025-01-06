using BepInEx.Unity.IL2CPP.Utils.Collections;
using UnityEngine;
using HarmonyLib;

namespace NoTrafficModNRP.HPatchers
{
    internal static class HPatch
    {
        [HarmonyPatch(typeof(RCC_CarControllerV3), "Start")]
        [HarmonyPrefix]
        public static void Start(RCC_CarControllerV3 __instance)
        {
            if (!IsDriveScene()) return;
            GodConstant.Instance.trafficManager.enabled = false;
        }

        private static bool IsDriveScene()
        {
            var scene = GodConstant.Instance.scene_currentType;
            var gameMode = GodConstant.Instance.game_currentMode;
            return GodConstant.Instance.scene_currentType == GodConstant.Scene_currentType.FREEROAM && gameMode != GodConstant.Game_currentMode.main_menu;
        } // from https://github.com/Scoolnik/SK.NRMods/blob/1e26767c73ba66dbd2901ef44ae01cb35fdd59da/SK.NRMods.DragStats/HarmonyPatchers/DragStatsPatch.cs#L85
    }
}
