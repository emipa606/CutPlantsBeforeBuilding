using HarmonyLib;
using RimWorld;
using Verse;

namespace CutPlantsBeforeBuilding.HarmonyPatches;

[HarmonyPatch(typeof(PlantUtility), nameof(PlantUtility.PawnWillingToCutPlant_Job))]
public class PlantUtility_PawnWillingToCutPlant_Job
{
    public static void Postfix(Pawn pawn, ref bool __result)
    {
        if (!__result)
        {
            return;
        }

        if (!CutPlantsBeforeBuildingMod.Instance.Settings.OnlyCutters)
        {
            return;
        }

        if (!pawn.workSettings.WorkIsActive(WorkTypeDefOf.PlantCutting))
        {
            __result = false;
        }
    }
}