using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using Verse;

namespace CutPlantsBeforeBuilding.HarmonyPatches;

[HarmonyPatch(typeof(AutoBuildRoofAreaSetter), "TryGenerateAreaNow")]
public static class AutoBuildRoofAreaSetter_TryGenerateAreaNow
{
    public static void Postfix(Map ___map, HashSet<IntVec3> ___innerCells)
    {
        foreach (var item in ___innerCells.Where(item =>
                     ___map.thingGrid.ThingsAt(item).Any(item2 => item2.def.plant is { interferesWithRoof: true })))
        {
            Util.DesignatePlant(item, ___map);
        }
    }
}