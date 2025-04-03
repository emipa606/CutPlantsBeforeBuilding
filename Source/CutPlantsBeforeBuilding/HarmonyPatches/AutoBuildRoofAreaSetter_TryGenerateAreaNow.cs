using System.Collections.Generic;
using HarmonyLib;
using Verse;

namespace CutPlantsBeforeBuilding.HarmonyPatches;

[HarmonyPatch(typeof(AutoBuildRoofAreaSetter), "TryGenerateAreaNow")]
public class AutoBuildRoofAreaSetter_TryGenerateAreaNow
{
    public static void Postfix(Map ___map, HashSet<IntVec3> ___innerCells)
    {
        foreach (var item in ___innerCells)
        {
            foreach (var item2 in ___map.thingGrid.ThingsAt(item))
            {
                if (item2.def.plant is not { interferesWithRoof: true })
                {
                    continue;
                }

                Util.DesignatePlant(item, ___map);
                break;
            }
        }
    }
}