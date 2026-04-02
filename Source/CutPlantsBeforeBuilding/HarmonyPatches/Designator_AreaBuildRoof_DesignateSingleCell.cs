using System.Linq;
using HarmonyLib;
using RimWorld;
using Verse;

namespace CutPlantsBeforeBuilding.HarmonyPatches;

[HarmonyPatch(typeof(Designator_AreaBuildRoof), nameof(Designator_AreaBuildRoof.DesignateSingleCell))]
public class Designator_AreaBuildRoof_DesignateSingleCell
{
    public static void Postfix(Designator_AreaBuildRoof __instance, IntVec3 c)
    {
        if (__instance.Map.thingGrid.ThingsAt(c).Any(item => item.def.plant is { interferesWithRoof: true }))
        {
            Util.DesignatePlant(c, __instance.Map);
        }
    }
}