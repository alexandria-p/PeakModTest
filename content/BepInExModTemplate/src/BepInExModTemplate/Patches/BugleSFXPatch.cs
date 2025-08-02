using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;


namespace AlexTestTemplate.Patches;

[HarmonyPatch(typeof(BugleSFX))]
public class BugleSFXPatch
{
    [HarmonyPatch(nameof(BugleSFX.RPC_StartToot))]
    [HarmonyPostfix]
    private static void RPC_StartToot_Postfix(BugleSFX __instance, int clip)
    {
        Plugin.Log.LogInfo($"TOOOOOT!");
    }
}