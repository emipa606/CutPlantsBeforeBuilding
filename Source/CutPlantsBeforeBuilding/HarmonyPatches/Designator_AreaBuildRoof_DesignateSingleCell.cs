using HarmonyLib;
using RimWorld;
using Verse;

namespace CutPlantsBeforeBuilding.HarmonyPatches;

[HarmonyPatch(typeof(Designator_AreaBuildRoof), nameof(Designator_AreaBuildRoof.DesignateSingleCell))]
public class Designator_AreaBuildRoof_DesignateSingleCell
{
    public static void Postfix(Designator_AreaBuildRoof __instance, IntVec3 c)
    {
        foreach (var item in __instance.Map.thingGrid.ThingsAt(c))
        {
            if (item.def.plant is not { interferesWithRoof: true })
            {
                continue;
            }

            Util.DesignatePlant(c, __instance.Map);
            break;
        }
    }
}