using HarmonyLib;
using RimWorld;
using Verse;

namespace CutPlantsBeforeBuilding.HarmonyPatches;

[HarmonyPatch(typeof(Designator_Build), nameof(Designator_Build.DesignateSingleCell))]
internal class Designator_Build_DesignateSingleCell
{
    private static void Postfix(Designator_Build __instance, IntVec3 c, Rot4 ___placingRot)
    {
        Util.DesignatePlants(c, ___placingRot, __instance.PlacingDef, __instance.StuffDef, Find.CurrentMap);
    }
}