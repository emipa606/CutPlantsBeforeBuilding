using HarmonyLib;
using RimWorld;
using Verse;

namespace CutPlantsBeforeBuilding.HarmonyPatches;

[HarmonyPatch(typeof(Designator_Install), nameof(Designator_Install.DesignateSingleCell))]
public class Designator_Install_DesignateSingleCell
{
    public static void Postfix(Designator_Build __instance, IntVec3 c, Rot4 ___placingRot)
    {
        Util.DesignatePlants(c, ___placingRot, __instance.PlacingDef, __instance.StuffDef, Find.CurrentMap);
    }
}