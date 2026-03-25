using System;
using HarmonyLib;
using UnityEngine;

namespace CTDynMMTemplate
{
    internal class Patches
    {

        [HarmonyPatch(typeof(Application), "isEditor", MethodType.Getter)]
        [HarmonyPostfix]
        private static void EnableEditor(ref bool __result)
        {
            __result = true; // Force the game to think it's running in the editor, this is a basic standard patch.
            Plugin.logger.LogInfo("Editor enabled");
        }

    }
}
